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
using Energistics.DataAccess.WITSML141;
using Energistics.DataAccess.WITSML141.ComponentSchemas;
using Energistics.DataAccess.WITSML141.ReferenceData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PDS.WITSMLstudio.Store.Data.SidewallCores
{
    [TestClass]
    public partial class SidewallCore141StoreTests : SidewallCore141TestBase
    {
        public SidewallCore141StoreTests()
            : base(false)
        {
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_GetFromStore_Can_Get_SidewallCore()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            DevKit.GetAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
       }

        [TestMethod]
        public void SidewallCore141DataAdapter_AddToStore_Can_Add_SidewallCore()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_UpdateInStore_Can_Update_SidewallCore()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            DevKit.UpdateAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            DevKit.GetAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_DeleteFromStore_Can_Delete_SidewallCore()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            DevKit.DeleteAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            DevKit.GetAndAssert<SidewallCoreList, SidewallCore>(SidewallCore, isNotNull: false);
        }

        [TestMethod]
        public void SidewallCore141WitsmlStore_GetFromStore_Can_Transform_SidewallCore()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            // Re-initialize all capServer providers
            DevKit.Store.CapServerProviders = null;
            DevKit.Container.BuildUp(DevKit.Store);

            string typeIn, queryIn;
            var query = DevKit.List(DevKit.CreateQuery(SidewallCore));
            DevKit.SetupParameters<SidewallCoreList, SidewallCore>(query, ObjectTypes.SidewallCore, out typeIn, out queryIn);

            var options = OptionsIn.Join(OptionsIn.ReturnElements.All, OptionsIn.DataVersion.Version131);
            var request = new WMLS_GetFromStoreRequest(typeIn, queryIn, options, null);
            var response = DevKit.Store.WMLS_GetFromStore(request);

            Assert.IsFalse(string.IsNullOrWhiteSpace(response.XMLout));
            Assert.AreEqual((short)ErrorCodes.Success, response.Result);

            var result = WitsmlParser.Parse(response.XMLout);
            var version = ObjectTypes.GetVersion(result.Root);
            Assert.AreEqual(OptionsIn.DataVersion.Version131.Value, version);
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_AddToStore_Creates_ChangeLog()
        {
            AddParents();

            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            var result = DevKit.GetAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            var expectedHistoryCount = 1;
            var expectedChangeType = ChangeInfoType.add;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_UpdateInStore_Updates_ChangeLog()
        {
            AddParents();

            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            // Update the SidewallCore141
            SidewallCore.Name = "Change";
            DevKit.UpdateAndAssert(SidewallCore);

            var result = DevKit.GetAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            var expectedHistoryCount = 2;
            var expectedChangeType = ChangeInfoType.update;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_DeleteFromStore_Updates_ChangeLog()
        {
            AddParents();

            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            // Delete the SidewallCore141
            DevKit.DeleteAndAssert(SidewallCore);

            var expectedHistoryCount = 2;
            var expectedChangeType = ChangeInfoType.delete;
            DevKit.AssertChangeLog(SidewallCore, expectedHistoryCount, expectedChangeType);
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_ChangeLog_Tracks_ChangeHistory_For_Add_Update_Delete()
        {
            AddParents();

            // Add the SidewallCore141
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            // Verify ChangeLog for Add
            var result = DevKit.GetAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            var expectedHistoryCount = 1;
            var expectedChangeType = ChangeInfoType.add;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);

            // Update the SidewallCore141
            SidewallCore.Name = "Change";
            DevKit.UpdateAndAssert(SidewallCore);

            result = DevKit.GetAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            expectedHistoryCount = 2;
            expectedChangeType = ChangeInfoType.update;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);

            // Delete the SidewallCore141
            DevKit.DeleteAndAssert(SidewallCore);

            expectedHistoryCount = 3;
            expectedChangeType = ChangeInfoType.delete;
            DevKit.AssertChangeLog(SidewallCore, expectedHistoryCount, expectedChangeType);

            // Re-add the same SidewallCore141...
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            //... the same changeLog should be reused.
            result = DevKit.GetAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            expectedHistoryCount = 4;
            expectedChangeType = ChangeInfoType.add;
            DevKit.AssertChangeLog(result, expectedHistoryCount, expectedChangeType);

            DevKit.AssertChangeHistoryTimesUnique(result);
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_GetFromStore_Filter_ExtensionNameValue()
        {
            AddParents();

            var extensionName1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            var extensionName2 = DevKit.ExtensionNameValue("Ext-2", "2.0", "cm", PrimitiveType.@float);
            extensionName2.MeasureClass = MeasureClass.Length;
            var extensionName3 = DevKit.ExtensionNameValue("Ext-3", "3.0", "cm", PrimitiveType.unknown);

            SidewallCore.CommonData = new CommonData()
            {
                ExtensionNameValue = new List<ExtensionNameValue>()
                {
                    extensionName1, extensionName2, extensionName3
                }
            };

            // Add the SidewallCore141
            DevKit.AddAndAssert(SidewallCore);

            // Query for first extension
            var commonDataXml = "<commonData>" + Environment.NewLine +
                                "<extensionNameValue uid=\"\">" + Environment.NewLine +
                                "<name />{0}" + Environment.NewLine +
                                "</extensionNameValue>" + Environment.NewLine +
                                "</commonData>";

            var extValueQuery = string.Format(commonDataXml, "<dataType>double</dataType>");
            var queryXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid, extValueQuery);
            var result = DevKit.Query<SidewallCoreList, SidewallCore>(ObjectTypes.SidewallCore, queryXml, null, OptionsIn.ReturnElements.Requested);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            var resultSidewallCore = result[0];
            Assert.IsNotNull(resultSidewallCore);

            var commonData = resultSidewallCore.CommonData;
            Assert.IsNotNull(commonData);
            Assert.AreEqual(1, commonData.ExtensionNameValue.Count);

            var env = commonData.ExtensionNameValue[0];
            Assert.IsNotNull(env);
            Assert.AreEqual(extensionName1.Uid, env.Uid);
            Assert.AreEqual(extensionName1.Name, env.Name);

            // Query for second extension
            extValueQuery = string.Format(commonDataXml, "<measureClass>length</measureClass>");
            queryXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid, extValueQuery);
            result = DevKit.Query<SidewallCoreList, SidewallCore>(ObjectTypes.SidewallCore, queryXml, null, OptionsIn.ReturnElements.Requested);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            resultSidewallCore = result[0];
            Assert.IsNotNull(resultSidewallCore);

            commonData = resultSidewallCore.CommonData;
            Assert.IsNotNull(commonData);
            Assert.AreEqual(1, commonData.ExtensionNameValue.Count);

            env = commonData.ExtensionNameValue[0];
            Assert.IsNotNull(env);
            Assert.AreEqual(extensionName2.Uid, env.Uid);
            Assert.AreEqual(extensionName2.Name, env.Name);

            // Query for third extension
            extValueQuery = string.Format(commonDataXml, "<dataType>unknown</dataType>");
            queryXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid, extValueQuery);
            result = DevKit.Query<SidewallCoreList, SidewallCore>(ObjectTypes.SidewallCore, queryXml, null, OptionsIn.ReturnElements.Requested);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            resultSidewallCore = result[0];
            Assert.IsNotNull(resultSidewallCore);

            commonData = resultSidewallCore.CommonData;
            Assert.IsNotNull(commonData);
            Assert.AreEqual(1, commonData.ExtensionNameValue.Count);

            env = commonData.ExtensionNameValue[0];
            Assert.IsNotNull(env);
            Assert.AreEqual(extensionName3.Uid, env.Uid);
            Assert.AreEqual(extensionName3.Name, env.Name);
        }

        [TestMethod]
        public void SidewallCore141DataAdapter_ChangeLog_Syncs_SidewallCore_Name_Changes()
        {
            AddParents();

            // Add the SidewallCore141
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            // Assert that all SidewallCore names match corresponding changeLog names
            DevKit.AssertChangeLogNames(SidewallCore);

            // Update the SidewallCore141 names
            SidewallCore.Name = "Change";
            SidewallCore.NameWell = "Well Name Change";

            SidewallCore.NameWellbore = "Wellbore Name Change";

            DevKit.UpdateAndAssert(SidewallCore);

            // Assert that all SidewallCore names match corresponding changeLog names
            DevKit.AssertChangeLogNames(SidewallCore);
        }
    }
}