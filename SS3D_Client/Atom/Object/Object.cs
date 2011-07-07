﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SS3D.Atom.Object
{
    public class Object : Atom
    {
        public Object()
            : base()
        {
            collidable = true;
        }

        public override void Update()
        {
            base.Update();
        }
        protected override void HandleExtendedMessage(Lidgren.Network.NetIncomingMessage message)
        {
            base.HandleExtendedMessage(message);
        }
    }
}