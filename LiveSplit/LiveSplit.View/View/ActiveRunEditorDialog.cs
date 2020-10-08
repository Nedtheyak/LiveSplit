using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSplit.Model;

namespace LiveSplit.View
{
    public partial class ActiveRunEditorDialog : Form
    {
        public IRun Run { get; set; }
        public LiveSplitState CurrentState { get; set; }  // TODO: see if you can remove

        public ActiveRunEditorDialog(LiveSplitState state)
        {
            InitializeComponent();
            CurrentState = state;
            Run = CurrentState.Run;
        }

        private void ActiveRunEditorDialog_Load(object sender, EventArgs e)
        {
            if (!(CurrentState.CurrentPhase == TimerPhase.Running || CurrentState.CurrentPhase == TimerPhase.Paused))
            {
                // Disabled when timer is *stopped* because I'm not confident I can implement it properly
                checkBoxSetTimer.Enabled = false;
                textBoxTimerControl.Enabled = false;
            }
            for (int i = 0; i < Run.Count; i++)
            {
                dataGridView.Rows.Add(new object[]
                {
                    i < CurrentState.CurrentSplitIndex,                  // Completed
                    Run[i].Name,                                         // Split Name
                    Run[i].SplitTime[CurrentState.CurrentTimingMethod],  // Time
                });
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Run.Count == dataGridView.RowCount)
            {
                CurrentState.CurrentSplitIndex = 0;
                for (int i = 0; i < Run.Count; i++)
                {
                    bool splitCompleted = (bool)dataGridView.Rows[i].Cells[0].Value;
                    if (splitCompleted)
                    {
                        TimeSpan? splitTS = (dataGridView.Rows[i].Cells[2].Value != null) ?
                        TimeSpanParser.ParseNullable(dataGridView.Rows[i].Cells[2].Value.ToString()) : null;
                        if (splitTS.HasValue)
                        {
                            Run[i].SplitTime = new Time(CurrentState.CurrentTimingMethod, splitTS);
                        }
                        CurrentState.CurrentSplitIndex = (i < Run.Count - 1) ? i + 1 : i;
                    }
                }
            }

            if (checkBoxSetTimer.Checked)
            {
                TimeSpan? newTimerValue = TimeSpanParser.ParseNullable(textBoxTimerControl.Text);

                if (newTimerValue.HasValue && (CurrentState.CurrentPhase == TimerPhase.Running || CurrentState.CurrentPhase == TimerPhase.Paused))
                {
                    // Set Split Time
                    CurrentState.CurrentSplit.SplitTime = new Time(CurrentState.CurrentTimingMethod, newTimerValue);

                    // Set Real Time
                    TimeSpan loadingTimeOffset = (CurrentState.CurrentTimingMethod == TimingMethod.RealTime) ? TimeSpan.Zero : CurrentState.LoadingTimes;
                    CurrentState.AdjustedStartTime = TimeStamp.Now - (newTimerValue.Value + loadingTimeOffset);
                    if (CurrentState.CurrentPhase == TimerPhase.Paused)
                    {
                        CurrentState.TimePausedAt = newTimerValue.Value + loadingTimeOffset;
                    }

                    // Set Game Time
                    if (CurrentState.CurrentTimingMethod == TimingMethod.GameTime && CurrentState.IsGameTimePaused)
                    {
                        CurrentState.GameTimePauseTime = newTimerValue;
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
