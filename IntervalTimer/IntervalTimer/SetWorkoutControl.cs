using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntervalTimer.Database;

namespace IntervalTimer
{
    public partial class SetWorkoutControl : UserControl
    {
        List<ExerciseModel> exercises = new List<ExerciseModel>();
        List<ComboItem> exerciseComboList = new List<ComboItem>();
        private ListViewItem _itemDnD = null;
       // private const int WM_PAINT = 0x000f;
       
        public SetWorkoutControl()
        {
            InitializeComponent();

            exercises = ExerciseDataAccess.LoadExercises();

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            foreach(ExerciseModel item in exercises)
            {
                data.Add(item.ExerciseName);
            }

            textBox_exerciseDescription.AutoCompleteCustomSource = data;
            

        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
           /* ComboItem comboItem = (ComboItem)comboBox_selectExercise.SelectedItem;
            if (comboItem.Text != "" && nudExerciseTime.Value > 0)
            {
                string[] row = { comboItem.Text, nudExerciseTime.Value.ToString() };
                ListViewItem exerciseItem = new ListViewItem(row);
                lvWorkout.Items.Add(exerciseItem);                                             
            }
            comboBox_selectExercise.SelectedIndex = -1;*/

            if (textBox_exerciseDescription.Text != "" && nudExerciseTime.Value > 0)
            {
                string[] row = { textBox_exerciseDescription.Text, nudExerciseTime.Value.ToString() };
                ListViewItem exerciseItem = new ListViewItem(row);
                lvWorkout.Items.Add(exerciseItem);
                textBox_exerciseDescription.Text = "";  // Clear input box
            }

        }

        private void btnSaveWorkout_Click(object sender, EventArgs e)
        {
            List<ExerciseRepModel> exercises = new List<ExerciseRepModel>();

            foreach (ListViewItem item in lvWorkout.Items)
            {
                ExerciseRepModel exerciseRepModel = new ExerciseRepModel();
                exerciseRepModel.ExerciseName = item.SubItems[0].Text;
                exerciseRepModel.Duration = int.Parse(item.SubItems[1].Text);
                exercises.Add(exerciseRepModel);
            }

            // TODO: Check if values valid
            Settings.Instance.setExercises(exercises);
            Settings.Instance.setTransitionTime((int)nud_transitionBetweenReps.Value);
            Settings.Instance.setSetRest((int)nud_restBetweenSets.Value);
            Settings.Instance.setNumSets((int)nud_numSets.Value);

            MessageBox.Show("<---- Click 'Start Workout' to begin", "Workout Loaded Successfully");
        }

        private void lvWorkout_MouseDown(object sender, MouseEventArgs e)
        {
            _itemDnD = lvWorkout.GetItemAt(e.X, e.Y);
        }

        private void lvWorkout_MouseMove(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null)
            {
                return;
            }

            Cursor = Cursors.Hand;
        }

        private void lvWorkout_MouseUp(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null)
            {
                return;
            }

            ListViewItem itemOver = lvWorkout.GetItemAt(e.X, e.Y);

            if (itemOver == null)
            {
                return;
            }

            Rectangle rect = itemOver.GetBounds(ItemBoundsPortion.Entire);

            // determine if we insert before or after item over
            bool insertBefore = false;

            if (e.Y < rect.Top + (rect.Height / 2))
            {                
                insertBefore = true;
            }

            if (_itemDnD != itemOver)
            {
                if (insertBefore)
                {
                    lvWorkout.Items.Remove(_itemDnD);
                    lvWorkout.Items.Insert(itemOver.Index, _itemDnD);
                }
                else
                {
                    // Insert After
                    lvWorkout.Items.Remove(_itemDnD);
                    lvWorkout.Items.Insert(itemOver.Index + 1, _itemDnD);
                }
            }

            Cursor = Cursors.Default;
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            List<ExerciseRepModel> exercises = new List<ExerciseRepModel>();

            Settings.Instance.setExercises(exercises);
            lvWorkout.Items.Clear();
        }

        private void comboBox_selectExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Bind this to refresh list if database changes
            exercises = ExerciseDataAccess.LoadExercises();

            exerciseComboList.Clear();
            foreach (ExerciseModel item in exercises)
            {
                exerciseComboList.Add(new ComboItem { Id = item.Id, Text = item.ExerciseName });
            }
        }

        /* private void exercisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
         {
             this.Validate();
             this.exercisesBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.savedWorkoutsDBDataSet);

         }
        */
        /*  protected override void WndProc(ref Message m)
          {
              base.WndProc(ref m);

              if (m.Msg == WM_PAINT)
              {
                  if (LineBefore <= 0 && LineBefore < lvWorkout.Items.Count)
                  {
                      Rectangle rect = lvWorkout.Items[LineBefore].GetBounds(ItemBoundsPortion.Entire);
                      DrawInsertionLine(rect.Left, rect.Right, rect.Top);
                  }

                  if (LineAfter >= 0 && LineBefore < lvWorkout.Items.Count)
                  {
                      Rectangle rect = lvWorkout.Items[LineAfter].GetBounds(ItemBoundsPortion.Entire);
                      DrawInsertionLine(rect.Left, rect.Right, rect.Top);
                  }
              }
          }*/

        /* private void lvWorkout_ItemDrag(object sender, ItemDragEventArgs e)
         {
             lvWorkout.DoDragDrop(lvWorkout.SelectedItems, DragDropEffects.Move);
         }

         private void lvWorkout_DragEnter(object sender, DragEventArgs e)
         {
             e.Effect = DragDropEffects.Move;
         }

         private void lvWorkout_DragDrop(object sender, DragEventArgs e)
         {
             if (lvWorkout.SelectedItems.Count == 0)
             {
                 return;
             }

             Point point = lvWorkout.PointToClient(new Point(e.X, e.Y));
             ListViewItem ItemDrag = lvWorkout.GetItemAt(point.X, point.Y);

             if (ItemDrag == null)
             {
                 return;
             }

             int ItemDragIndex = ItemDrag.Index;
             ListViewItem[] sel = new ListViewItem[lvWorkout.SelectedItems.Count];

             for ( int i = 0; i < lvWorkout.SelectedItems.Count; i++)
             {
                 sel[i] = lvWorkout.SelectedItems[i];
             }

             for ( int i = 0; i < sel.GetLength(0); i++)
             {
                 ListViewItem item = sel[i];
                 int itemIndex = ItemDragIndex;

                 if (itemIndex == item.Index)
                 {
                     return;
                 }

                 if (item.Index < itemIndex)
                 {
                     itemIndex++;
                 }
                 else 
                 {
                     itemIndex = ItemDragIndex + 1;
                 }

                 ListViewItem insertItem = (ListViewItem)item.Clone();
                 lvWorkout.Items.Insert(itemIndex, insertItem);
                 lvWorkout.Items.Remove(item);

             }

         }*/

    }
}
