using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multiplayer.Hubs
{
    public class Figure:Hub
    {
        public void Move(string direction)
        {
            switch (direction)
            {
                case "left": Clients.All.moveLeft(); break;
                case "right": Clients.All.moveRight(); break;
                case "up": Clients.All.moveUp(); break;
                case "down": Clients.All.moveDown(); break;
                case "jump": Clients.All.jump(); break;
            }
            
        }
    }
}