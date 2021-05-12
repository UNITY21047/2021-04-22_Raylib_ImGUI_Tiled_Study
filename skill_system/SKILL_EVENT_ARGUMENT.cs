using System;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class SKILL_EVENT_ARGUMENTS
    {
          List<EventArgs> ARGUMENTS = new List<EventArgs>();

          public void LOAD_ARGUMENT(EventArgs argument)
          {
              ARGUMENTS.Add(argument);
          }
    }
}