using System;
using System.Collections.Generic;

namespace StaticEventHandlers
{
    public class Proposer : IHandle<Promise>, IHandle<Learned>
    {
        private readonly string _clientProposal;
        private readonly Action<bool> _onCompletionCallback;
        private int _numberOfNodes;
        private int _nodeId;
        private int Majority => _numberOfNodes / 2 + 1;

        private bool _decisionReached = false;

        public Proposer(string clientProposal, Action<bool> onCompletionCallback)
        {
            _clientProposal = clientProposal;
            _onCompletionCallback = onCompletionCallback;
        }

        public void Start()
        {
            var ballot = -_nodeId;
            while (true)
            {
                ballot += _numberOfNodes;
                HoldElection(ballot);
                SleepRandomTimeout();
                if (_decisionReached)
                    return;
            }
        }

        public void HoldElection(int ballot)
        {
            Broadcast(new Prepare(ballot));
        }

        public void Handle(Promise p)
        {
        }

        public void Handle(Learned l)
        {
        }

        public void Handle(Nack n)
        {
        }

        string FindValue(IEnumerable<Promise> promises, string clientProposal) => throw new NotImplementedException();

        void SleepRandomTimeout() => throw new NotImplementedException();

        public void Broadcast(object msg) => throw new NotImplementedException();
    }
}