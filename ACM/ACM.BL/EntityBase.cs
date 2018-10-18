using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        #region "Enums"
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        #endregion

        #region "Properties"

        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; set; }
        public bool HasChanges { get; set; }
        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }

        #endregion

        #region "Functionality"


        public abstract bool Validate();

        #endregion
    }
}
