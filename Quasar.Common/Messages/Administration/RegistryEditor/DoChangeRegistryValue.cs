﻿using ProtoBuf;
using Quasar.Common.Messages.other;
using Quasar.Common.Models;

namespace Quasar.Common.Messages.Administration.RegistryEditor
{
    [ProtoContract]
    public class DoChangeRegistryValue : IMessage
    {
        [ProtoMember(1)]
        public string KeyPath { get; set; }

        [ProtoMember(2)]
        public RegValueData Value { get; set; }
    }
}
