﻿namespace Sample.Common.Commands
{
    using Sequin.Core;

    public class DummyCommandHandler : IHandler<DummyCommand>
    {
        public void Handle(DummyCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}