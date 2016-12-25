﻿using System.Diagnostics.Contracts;

namespace FxSsh.Services
{
    public abstract class SshService
    {
        protected internal readonly Session _session;

        public SshService(Session session)
        {
            Contract.Requires(session != null);

            _session = session;
        }

        protected internal abstract void CloseService();
    }
}