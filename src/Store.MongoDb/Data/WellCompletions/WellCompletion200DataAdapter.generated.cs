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
using System.ComponentModel.Composition;
using System.Linq;
using Energistics.DataAccess.WITSML200;
using Energistics.DataAccess.WITSML200.ComponentSchemas;
using Energistics.Etp.Common.Datatypes;
using LinqToQuerystring;
using PDS.WITSMLstudio.Framework;
using PDS.WITSMLstudio.Store.Configuration;

namespace PDS.WITSMLstudio.Store.Data.WellCompletions
{
    /// <summary>
    /// Data adapter that encapsulates CRUD functionality for <see cref="WellCompletion" />
    /// </summary>
    /// <seealso cref="PDS.WITSMLstudio.Store.Data.MongoDbDataAdapter{WellCompletion}" />
    [Export(typeof(IWitsmlDataAdapter<WellCompletion>))]
    [Export200(ObjectTypes.WellCompletion, typeof(IWitsmlDataAdapter))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class WellCompletion200DataAdapter : MongoDbDataAdapter<WellCompletion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WellCompletion200DataAdapter" /> class.
        /// </summary>
        /// <param name="container">The composition container.</param>
        /// <param name="databaseProvider">The database provider.</param>
        [ImportingConstructor]
        public WellCompletion200DataAdapter(IContainer container, IDatabaseProvider databaseProvider)
            : base(container, databaseProvider, ObjectNames.WellCompletion200, ObjectTypes.Uuid)
        {
            Logger.Verbose("Instance created.");
        }

        /// <summary>
        /// Gets a collection of data objects related to the specified URI.
        /// </summary>
        /// <param name="parentUri">The parent URI.</param>
        /// <returns>A collection of data objects.</returns>
        public override List<WellCompletion> GetAll(EtpUri? parentUri)
        {
            Logger.DebugFormat("Fetching all WellCompletions; Parent URI: {0}", parentUri);

            return GetAllQuery(parentUri)
                .OrderBy(x => x.Citation.Title)
                .ToList();
        }

        /// <summary>
        /// Gets an <see cref="IQueryable{WellCompletion}" /> instance to by used by the GetAll method.
        /// </summary>
        /// <param name="parentUri">The parent URI.</param>
        /// <returns>An executable query.</returns>
        protected override IQueryable<WellCompletion> GetAllQuery(EtpUri? parentUri)
        {
            var query = GetQuery().AsQueryable();

            if (parentUri != null)
            {
                var uidWell = parentUri.Value.ObjectId;

                if (!string.IsNullOrWhiteSpace(uidWell))
                    query = query.Where(x => x.Well.Uuid == uidWell);

                if (!string.IsNullOrWhiteSpace(parentUri.Value.Query))
                    query = query.LinqToQuerystring(parentUri.Value.Query);
            }

            return query;
        }
    }
}