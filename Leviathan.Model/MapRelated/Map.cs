using System;
using System.Collections.Generic;
using System.Linq;

using Leviathan.Model.Exceptions;

namespace Leviathan.Model.MapRelated
{
    public class Map
    {
        #region Properties

        public Region Region { get; set; }

        private Int32 _current;
        [Newtonsoft.Json.JsonIgnore]
        public Segment Current
        {
            get
            {
                return Segments[_current];
            }
        }

        public List<Segment> Segments { get; set; }

        public List<String> Variables { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public List<Condition> Conditions
        {
            get
            {
                List<Condition> result = new List<Condition>();
                foreach(Segment seg in Segments)
                {
                    foreach(MoveOption mov in seg.Options)
                    {
                        result.Add(mov.Condition);
                    }
                }
                return result;
            }
        }

        #endregion

        #region Events

        public event EventHandler Battle;
        private void OnBattle()
        {
            if (Battle != null)
                Battle(this, EventArgs.Empty);
        }

        public event EventHandler VariableSet;
        private void OnVariableSet()
        {
            if (VariableSet != null)
                VariableSet(this, EventArgs.Empty);
        }

        public event EventHandler ExperienceGain;
        private void OnExperienceGain()
        {
            if (ExperienceGain != null)
                ExperienceGain(this, EventArgs.Empty);
        }

        public event EventHandler ItemGain;
        private void OnItemGain()
        {
            if (ItemGain != null)
                ItemGain(this, EventArgs.Empty);
        }

        public event EventHandler ChangeRegion;
        private void OnChangeRegion()
        {
            if (ChangeRegion != null)
                ChangeRegion(this, EventArgs.Empty);
        }

        #endregion

        #region Constructors

        public Map(bool createDefaultSegment = false)
        {
            _current = 0;
            Segments = new List<Segment>();
            Variables = new List<string>();
            if (createDefaultSegment)
            {
                Segments.Add(new Segment());
            }
        }

        public void SetUp(Int32 id)
        {
            _current = id;
        }

        #endregion

        #region Public Methods

        public void GoToSegment(Int32 i)
        {
            if(Current.Options.Any(mo => mo.ToId == i))
            {
                _current = i;
                switch(Current.Special.Type)
                {
                    case Specials.SpecialType.None:
                        break;
                    case Specials.SpecialType.Battle:
                        OnBattle();
                        break;
                    case Specials.SpecialType.VariableSet:
                        OnVariableSet();
                        break;
                    case Specials.SpecialType.ExperienceGain:
                        OnExperienceGain();
                        break;
                    case Specials.SpecialType.ItemGain:
                        OnItemGain();
                        break;
                    case Specials.SpecialType.ChangeRegion:
                        OnChangeRegion();
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        #endregion

        #region Private Methods



        #endregion

    }
}
