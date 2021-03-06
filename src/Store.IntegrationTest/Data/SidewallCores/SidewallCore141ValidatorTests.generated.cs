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
using System;
using System.Collections.Generic;
using System.Linq;
using Energistics.DataAccess;
using Energistics.DataAccess.WITSML141;
using Energistics.DataAccess.WITSML141.ComponentSchemas;
using Energistics.DataAccess.WITSML141.ReferenceData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PDS.WITSMLstudio.Store.Data.SidewallCores
{
    [TestClass]
    public partial class SidewallCore141ValidatorTests : SidewallCore141TestBase
    {
        #region Error -401

        public static readonly string QueryInvalidPluralRoot =
            "<sidewallCore xmlns=\"http://www.witsml.org/schemas/1series\" version=\"1.4.1.1\">" + Environment.NewLine +
            "  <sidewallCore>" + Environment.NewLine +
            "    <name>Test Plural Root Element</name>" + Environment.NewLine +
            "  </sidewallCore>" + Environment.NewLine +
            "</sidewallCore>";

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_401_No_Plural_Root_Element()
        {
            var response = DevKit.GetFromStore(ObjectTypes.SidewallCore, QueryInvalidPluralRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingPluralRootElement, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_401_No_Plural_Root_Element()
        {
            var response = DevKit.AddToStore(ObjectTypes.SidewallCore, QueryInvalidPluralRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingPluralRootElement, response?.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_401_No_Plural_Root_Element()
        {
            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, QueryInvalidPluralRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingPluralRootElement, response?.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_DeleteFromStore_Error_401_No_Plural_Root_Element()
        {
            var response = DevKit.DeleteFromStore(ObjectTypes.SidewallCore, QueryInvalidPluralRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingPluralRootElement, response?.Result);
        }

        #endregion Error -401

        #region Error -402

        #endregion Error -402

        #region Error -403

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_403_RequestObjectSelectionCapability_True_MissingNamespace()
        {
            var response = DevKit.GetFromStore(ObjectTypes.SidewallCore, QueryMissingNamespace, null, optionsIn: OptionsIn.RequestObjectSelectionCapability.True);
            Assert.AreEqual((short)ErrorCodes.MissingDefaultWitsmlNamespace, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_403_RequestObjectSelectionCapability_True_BadNamespace()
        {
            var response = DevKit.GetFromStore(ObjectTypes.SidewallCore, QueryInvalidNamespace, null, optionsIn: OptionsIn.RequestObjectSelectionCapability.True);
            Assert.AreEqual((short)ErrorCodes.MissingDefaultWitsmlNamespace, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_403_RequestObjectSelectionCapability_None_BadNamespace()
        {
            var response = DevKit.GetFromStore(ObjectTypes.SidewallCore, QueryInvalidNamespace, null, optionsIn: OptionsIn.RequestObjectSelectionCapability.None);
            Assert.AreEqual((short)ErrorCodes.MissingDefaultWitsmlNamespace, response.Result);
        }

        #endregion Error -403

        #region Error -405

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_405_SidewallCore_Already_Exists()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore, ErrorCodes.DataObjectUidAlreadyExists);
        }

        #endregion Error -405

        #region Error -406

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_406_SidewallCore_Missing_Parent_Uid()
        {
            AddParents();
            SidewallCore.UidWellbore = null;
            DevKit.AddAndAssert(SidewallCore, ErrorCodes.MissingElementUidForAdd);
        }

        #endregion Error -406

        #region Error -407

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_407_SidewallCore_Missing_Witsml_Object_Type()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            var response = DevKit.Update<SidewallCoreList, SidewallCore>(SidewallCore, string.Empty);
            Assert.IsNotNull(response);
            Assert.AreEqual((short)ErrorCodes.MissingWmlTypeIn, response.Result);
        }

        #endregion Error -407

        #region Error -408

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_408_SidewallCore_Empty_QueryIn()
        {
            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, string.Empty, null, null);
            Assert.IsNotNull(response);
            Assert.AreEqual((short)ErrorCodes.MissingInputTemplate, response.Result);
        }

        #endregion Error -408

        #region Error -409

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_409_SidewallCore_XmlIn_Must_Conform_To_Schema()
        {
            AddParents();

            var nonConformingXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                $"<name>{SidewallCore.Name}</name><name>{SidewallCore.Name}</name>");

            var response = DevKit.AddToStore(ObjectTypes.SidewallCore, nonConformingXml, null, null);
            Assert.AreEqual((short)ErrorCodes.InputTemplateNonConforming, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_409_SidewallCore_XmlIn_Must_Conform_To_Schema()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            var nonConformingXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                $"<name>{SidewallCore.Name}</name><name>{SidewallCore.Name}</name>");

            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, nonConformingXml, null, null);
            Assert.AreEqual((short)ErrorCodes.InputTemplateNonConforming, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_409_SidewallCore_QueryIn_Must_Conform_To_Schema()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            var nonConformingXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                $"<name>{SidewallCore.Name}</name><name>{SidewallCore.Name}</name>");

            var response = DevKit.GetFromStore(ObjectTypes.SidewallCore, nonConformingXml, null, null);
            Assert.AreEqual((short)ErrorCodes.InputTemplateNonConforming, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_DeleteFromStore_Error_409_SidewallCore_QueryIn_Must_Conform_To_Schema()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            var nonConformingXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                $"<name>{SidewallCore.Name}</name><name>{SidewallCore.Name}</name>");

            var response = DevKit.DeleteFromStore(ObjectTypes.SidewallCore, nonConformingXml, null, null);
            Assert.AreEqual((short)ErrorCodes.InputTemplateNonConforming, response.Result);
        }

        #endregion Error -409

        #region Error -415

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_415_SidewallCore_Update_Without_Specifing_UID()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            SidewallCore.Uid = string.Empty;
            DevKit.UpdateAndAssert<SidewallCoreList, SidewallCore>(SidewallCore, ErrorCodes.DataObjectUidMissing);
        }

        #endregion Error -415
        #region Error -416

        [TestMethod]
        public void SidewallCore141Validator_DeleteFromStore_Error_416_SidewallCore_Delete_With_Empty_UID()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(SidewallCore);

            var deleteXml = string.Format(BasicXMLTemplate,SidewallCore.UidWell, SidewallCore.UidWellbore,SidewallCore.Uid,
                "<commonData><extensionNameValue uid=\"\" /></commonData>");

            var results = DevKit.DeleteFromStore(ObjectTypes.SidewallCore, deleteXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.EmptyUidSpecified, results.Result);
        }

        #endregion Error -416

        #region Error -418

        [TestMethod]
        public void SidewallCore141Validator_DeleteFromStore_Error_418_SidewallCore_Delete_With_Missing_Uid()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(SidewallCore);

            var deleteXml = string.Format(BasicXMLTemplate,SidewallCore.UidWell, SidewallCore.UidWellbore,SidewallCore.Uid,
                "<commonData><extensionNameValue  uid=\"\" /></commonData>");

            var results = DevKit.DeleteFromStore(ObjectTypes.SidewallCore, deleteXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.EmptyUidSpecified, results.Result);
        }

        #endregion Error -418

        #region Error -419

        [TestMethod]
        public void SidewallCore141Validator_DeleteFromStore_Error_419_SidewallCore_Deleting_Empty_NonRecurring_Container_Element()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(SidewallCore);

            var deleteXml = string.Format(BasicXMLTemplate,SidewallCore.UidWell, SidewallCore.UidWellbore,SidewallCore.Uid,
                "<commonData />");

            var results = DevKit.DeleteFromStore(ObjectTypes.SidewallCore, deleteXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.EmptyNonRecurringElementSpecified, results.Result);
        }

        #endregion Error -419
        #region Error -420

        [TestMethod]
        public void SidewallCore141Validator_DeleteFromStore_Error_420_SidewallCore_Specifying_A_Non_Recuring_Element_That_Is_Required()
        {
            AddParents();

            DevKit.AddAndAssert(SidewallCore);

            var deleteXml = string.Format(BasicXMLTemplate,SidewallCore.UidWell, SidewallCore.UidWellbore,SidewallCore.Uid,
                "<nameWell />");
            var results = DevKit.DeleteFromStore(ObjectTypes.SidewallCore, deleteXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.EmptyMandatoryNodeSpecified, results.Result);
        }

        #endregion Error -420

        #region Error -426

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_426_SidewallCore_Compressed_XmlIn_Must_Conform_To_Schema()
        {
            AddParents();

            var nonConformingXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                $"<name>{SidewallCore.Name}</name><name>{SidewallCore.Name}</name>");

            var optionsIn = string.Empty;
            ClientCompression.Compress(ref nonConformingXml, ref optionsIn);

            var response = DevKit.AddToStore(ObjectTypes.SidewallCore, nonConformingXml, null, optionsIn);
            Assert.AreEqual((short)ErrorCodes.CompressedInputNonConforming, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_426_SidewallCore_Compressed_XmlIn_Must_Conform_To_Schema()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            var nonConformingXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                $"<name>{SidewallCore.Name}</name><name>{SidewallCore.Name}</name>");

            var optionsIn = string.Empty;
            ClientCompression.Compress(ref nonConformingXml, ref optionsIn);

            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, nonConformingXml, null, optionsIn);
            Assert.AreEqual((short)ErrorCodes.CompressedInputNonConforming, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_426_SidewallCore_Compressed_QueryIn_Must_Conform_To_Schema()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            var nonConformingXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                $"<name>{SidewallCore.Name}</name><name>{SidewallCore.Name}</name>");

            var optionsIn = string.Empty;
            ClientCompression.Compress(ref nonConformingXml, ref optionsIn);

            var response = DevKit.GetFromStore(ObjectTypes.SidewallCore, nonConformingXml, null, optionsIn);
            Assert.AreEqual((short)ErrorCodes.CompressedInputNonConforming, response.Result);
        }

        #endregion Error -426

        #region Error -433

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_433_SidewallCore_Does_Not_Exist()
        {
            AddParents();
            DevKit.UpdateAndAssert<SidewallCoreList, SidewallCore>(SidewallCore, ErrorCodes.DataObjectNotExist);
        }

        #endregion Error -433

        #region Error -438

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_438_SidewallCore_Recurring_Elements_Have_Inconsistent_Selection()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            var ext2 = DevKit.ExtensionNameValue("Ext-2", "1.0", "m");

            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1, ext2
                }
            };

            DevKit.AddAndAssert(SidewallCore);

            var queryXml = string.Format(BasicXMLTemplate,SidewallCore.UidWell, SidewallCore.UidWellbore,SidewallCore.Uid,
                "<commonData>" +
                $"<extensionNameValue uid=\"\"><name>Ext-1</name></extensionNameValue>" +
                "<extensionNameValue uid=\"\"><value uom=\"\">1.0</value></extensionNameValue>" +
                "</commonData>");

            var results = DevKit.GetFromStore(ObjectTypes.SidewallCore, queryXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.RecurringItemsInconsistentSelection, results.Result);
        }

        #endregion Error -438

        #region Error -439

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_439_SidewallCore_Recurring_Elements_Has_Empty_Selection_Value()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            var ext2 = DevKit.ExtensionNameValue("Ext-2", "1.0", "m");

            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1, ext2
                }
            };

            DevKit.AddAndAssert(SidewallCore);

            var queryXml = string.Format(BasicXMLTemplate,SidewallCore.UidWell, SidewallCore.UidWellbore,SidewallCore.Uid,
                "<commonData>" +
                $"<extensionNameValue uid=\"\"><name>Ext-1</name></extensionNameValue>" +
                "<extensionNameValue uid=\"\"><name></name></extensionNameValue>" +
                "</commonData>");

            var results = DevKit.GetFromStore(ObjectTypes.SidewallCore, queryXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.RecurringItemsEmptySelection, results.Result);
        }

        #endregion Error -439
        #region Error -444

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_444_SidewallCore_Updating_More_Than_One_Data_Object()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            var updateXml = "<sidewallCores xmlns=\"http://www.witsml.org/schemas/1series\" version=\"1.4.1.1\"><sidewallCore uidWell=\"{0}\" uidWellbore=\"{1}\" uid=\"{2}\"></sidewallCore><sidewallCore uidWell=\"{0}\" uidWellbore=\"{1}\" uid=\"{2}\"></sidewallCore></sidewallCores>";
            updateXml = string.Format(updateXml, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid);

            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, updateXml, null, null);
            Assert.AreEqual((short)ErrorCodes.InputTemplateMultipleDataObjects, response.Result);
        }

        #endregion Error -444

        #region Error -445

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_445_SidewallCore_Empty_New_Element()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(SidewallCore);

            ext1 = DevKit.ExtensionNameValue("Ext-1", string.Empty, string.Empty, PrimitiveType.@double, string.Empty);
            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.UpdateAndAssert(SidewallCore, ErrorCodes.EmptyNewElementsOrAttributes);
        }

        #endregion Error -445

        #region Error -448

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_448_SidewallCore_Missing_Uid()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(SidewallCore);

            var updateXml = string.Format(BasicXMLTemplate,SidewallCore.UidWell, SidewallCore.UidWellbore,SidewallCore.Uid,
                "<commonData>" +
                $"<extensionNameValue uid=\"\"><value uom=\"ft\" /></extensionNameValue>" +
                "</commonData>");

            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, updateXml, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingElementUidForUpdate, response.Result);
        }

        #endregion Error -448

        #region Error -464

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_464_SidewallCore_Uid_Not_Unique()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            var ext2 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1, ext2
                }
            };

            DevKit.AddAndAssert(SidewallCore, ErrorCodes.ChildUidNotUnique);
        }

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_464_SidewallCore_Uid_Not_Unique()
        {
            AddParents();
            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(SidewallCore);

            var ext2 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            SidewallCore.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1, ext2
                }
            };

            DevKit.UpdateAndAssert(SidewallCore, ErrorCodes.ChildUidNotUnique);
        }

        #endregion Error -464
        #region Error -468

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_468_SidewallCore_No_Schema_Version_Declared()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, QueryMissingVersion, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingDataSchemaVersion, response.Result);
        }

        #endregion Error -468

        #region Error -478

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_478_SidewallCore_Parent_Uid_Case_Not_Matching()
        {
            Well.Uid = Well.Uid.ToUpper();
            Wellbore.Uid = Wellbore.Uid.ToUpper();
            Wellbore.UidWell = Well.Uid.ToUpper();
            AddParents();

            SidewallCore.UidWell = Well.Uid.ToLower();

            DevKit.AddAndAssert(SidewallCore, ErrorCodes.IncorrectCaseParentUid);
        }

        #endregion Error -478

        #region Error -479

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_479_SidewallCore_Cannot_Decompress_XmlIn()
        {
            AddParents();

            var uncompressedXml = "abcd1234";
            var compressedXml = uncompressedXml;

            var optionsIn = string.Empty;
            ClientCompression.Compress(ref compressedXml, ref optionsIn);

            var response = DevKit.AddToStore(ObjectTypes.SidewallCore, uncompressedXml, null, optionsIn);
            Assert.AreEqual((short)ErrorCodes.CannotDecompressQuery, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_479_SidewallCore_Cannot_Decompress_XmlIn()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            var uncompressedXml = "abcd1234";
            var compressedXml = uncompressedXml;

            var optionsIn = string.Empty;
            ClientCompression.Compress(ref compressedXml, ref optionsIn);

            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, uncompressedXml, null, optionsIn);
            Assert.AreEqual((short)ErrorCodes.CannotDecompressQuery, response.Result);
        }

        [TestMethod]
        public void SidewallCore141Validator_GetFromStore_Error_479_SidewallCore_Cannot_Decompress_XmlIn()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);

            var uncompressedXml = "abcd1234";
            var compressedXml = uncompressedXml;

            var optionsIn = string.Empty;
            ClientCompression.Compress(ref compressedXml, ref optionsIn);

            var response = DevKit.GetFromStore(ObjectTypes.SidewallCore, uncompressedXml, null, optionsIn);
            Assert.AreEqual((short)ErrorCodes.CannotDecompressQuery, response.Result);
        }

        #endregion Error -479

        #region Error -481

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_481_SidewallCore_Parent_Does_Not_Exist()
        {
            DevKit.AddAndAssert(SidewallCore, ErrorCodes.MissingParentDataObject);
        }

        #endregion Error -481

        #region Error -483

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_483_SidewallCore_Update_With_Non_Conforming_Template()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, QueryEmptyRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.UpdateTemplateNonConforming, response.Result);
        }

        #endregion Error -483

        #region Error -484

        [TestMethod]
        public void SidewallCore141Validator_UpdateInStore_Error_484_SidewallCore_Update_Will_Delete_Required_Element()
        {
            AddParents();
            DevKit.AddAndAssert<SidewallCoreList, SidewallCore>(SidewallCore);
            var nonConformingXml = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                $"<nameWell></nameWell>");

            var response = DevKit.UpdateInStore(ObjectTypes.SidewallCore, nonConformingXml, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingRequiredData, response.Result);
        }

        #endregion Error -484

        #region Error -486

        [TestMethod]
        public void SidewallCore141Validator_AddToStore_Error_486_SidewallCore_Data_Object_Types_Dont_Match()
        {
            AddParents();

            var xmlIn = string.Format(BasicXMLTemplate, SidewallCore.UidWell, SidewallCore.UidWellbore, SidewallCore.Uid,
                string.Empty);

            var response = DevKit.AddToStore(ObjectTypes.Well, xmlIn, null, null);
            Assert.AreEqual((short)ErrorCodes.DataObjectTypesDontMatch, response.Result);
        }

        #endregion Error -486
    }
}