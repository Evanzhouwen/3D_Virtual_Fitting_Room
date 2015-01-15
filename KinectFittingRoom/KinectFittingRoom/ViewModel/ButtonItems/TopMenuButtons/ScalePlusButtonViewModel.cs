﻿using KinectFittingRoom.ViewModel.ClothingItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinectFittingRoom.ViewModel.ButtonItems.TopMenuButtons
{
    class ScalePlusButtonViewModel : TopMenuButtonViewModel
    {
        #region Consts
        private const double PlusFactor = 0.05;
        #endregion
        #region .ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="ScalePlusButtonViewModel"/> class.
        /// </summary>
        /// <param name="image">Image of button</param>
        public ScalePlusButtonViewModel(Bitmap image)
            : base(image)
        { }
        #endregion
        #region Methods
        /// <summary>
        /// Makes last added item bigger
        /// </summary>
        public override void ClickEventExecuted()
        {
            if (ClothingManager.Instance.ChosenClothesModels.Count != 0)
            {
                ClothingManager.Instance.ScaleImageHeight(PlusFactor);
                ClothingManager.Instance.ScaleImageWidth(PlusFactor);
            }
        }
        #endregion
    }
}