//----------------------------------------------------------------------- 
// PDS WITSMLstudio Store, 2018.3
//
// Copyright 2018 PDS Americas LLC
// 
// Licensed under the PDS Open Source WITSML Product License Agreement (the
// "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.pds.group/WITSMLstudio/OpenSource/ProductLicenseAgreement
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

// ----------------------------------------------------------------------
// <auto-generated>
//     Changes to this file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------

using Energistics.DataAccess;
using Energistics.DataAccess.WITSML200;
using Energistics.DataAccess.WITSML200.ComponentSchemas;
using Energistics.DataAccess.WITSML200.ReferenceData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PDS.WITSMLstudio.Store.Data.DepthRegImages
{
    [TestClass]
    public partial class DepthRegImage200StoreTests : DepthRegImage200TestBase
    {
        public DepthRegImage200StoreTests()
            : base(false)
        {
        }

        [TestMethod]
        public void DepthRegImage200DataAdapter_GetFromStore_Can_Get_DepthRegImage()
        {
            AddParents();
            DevKit.AddAndAssert(DepthRegImage);
            DevKit.GetAndAssert(DepthRegImage);
       }

        [TestMethod]
        public void DepthRegImage200DataAdapter_AddToStore_Can_Add_DepthRegImage()
        {
            AddParents();
            DevKit.AddAndAssert(DepthRegImage);
        }

        [TestMethod]
        public void DepthRegImage200DataAdapter_UpdateInStore_Can_Update_DepthRegImage()
        {
            AddParents();
            DevKit.AddAndAssert(DepthRegImage);
            DevKit.UpdateAndAssert(DepthRegImage);
            DevKit.GetAndAssert(DepthRegImage);
        }

        [TestMethod]
        public void DepthRegImage200DataAdapter_DeleteFromStore_Can_Delete_DepthRegImage()
        {
            AddParents();
            DevKit.AddAndAssert(DepthRegImage);
            DevKit.DeleteAndAssert(DepthRegImage);
            DevKit.GetAndAssert(DepthRegImage, isNotNull: false);
        }
    }
}