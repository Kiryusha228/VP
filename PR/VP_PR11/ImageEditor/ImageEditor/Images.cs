using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditor
{
    public class Images
    {
        private List<Bitmap> _imagesList;
        private int _current;

        public Images()
        {
            _imagesList = new List<Bitmap>();
            _current = -1;
        }

        public void Add(Bitmap image)
        {
            Drop();
            _imagesList.Add(image);
            _current++;
        }

        public void Remove(int index) 
        {
            _imagesList.RemoveAt(index);
        }

        public Bitmap Undo()
        {
            if (_current == 0)
            {
                return _imagesList[_current];
            }

            return _imagesList[--_current];
        }
        public Bitmap Redo()
        {
            if (_current == _imagesList.Count - 1)
            {
                return _imagesList[_current];
            }

            return _imagesList[++_current];
        }

        public void Drop()
        {
            while (_current < _imagesList.Count - 1)
            {
                _imagesList.RemoveAt(_imagesList.Count - 1);
            }
        }

        public Bitmap Get()
        {
            return _imagesList[_current];
        }
    }
}
