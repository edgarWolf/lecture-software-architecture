using Microsoft.AspNetCore.Components;

namespace Aufgabe_9._2.Pages {
    public partial class DiceView : IObserver {
        private Controller _Controller;
        private DiceWithMemory _DiceWithMemory;

        public int High { get; set; } = 1;
        public int Low { get; set; } = 6;

        public int LatestRoll => _DiceWithMemory.GetLatestRoll();

        public List<int> LatestFiveRolls => _DiceWithMemory.GetLastFiveRolls();

        public void Update(IObservable observable)
        {
            _DiceWithMemory = observable as DiceWithMemory;

        }

        protected override void OnInitialized()
        {
            _Controller = new();
            _DiceWithMemory = new();
            _Controller.Init(_DiceWithMemory, this);
            RollDice();
        }

        public void RollDice() {
            _Controller.RollDice(High, Low);
        }

    }
}
