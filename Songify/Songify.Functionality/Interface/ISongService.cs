using Songify.Functionality.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songify.Functionality.Interface
{
    public interface ISongService
    {
        void Play(string path);
        void Pause();
        void TogglePlayPause();
        void Next();
        void Previous();
        void ToggleLoop();
        void ToggleShuffle();

    }
}
