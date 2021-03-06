﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SomeStore.Models;
using SomeStore.Models.Repository;

namespace SomeStore.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected IEnumerable<Game> GetGames()
        {
            return repository.Games;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}