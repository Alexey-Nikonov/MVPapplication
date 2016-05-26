using System;
using System.Windows.Forms;
using System.IO;

namespace MVPapplication
{
    class TxtProvider : IProvider
    {
        public Script Load()
        {
            throw new Exception("There is no implementation");
        }

        public void Save(object @object)
        {
            var items = @object as ListBox.ObjectCollection;

            SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Текстовые документы (*.txt)|*.txt|Все файлы|*.*" };
            saveFileDialog.ShowDialog();

            using (TextWriter textWritter = new StreamWriter(saveFileDialog.FileName))
            {
                foreach (var item in items)
                {
                    textWritter.WriteLine(item);
                }
            }
        }
    }
}