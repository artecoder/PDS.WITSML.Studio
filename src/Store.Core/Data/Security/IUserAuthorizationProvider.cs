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

namespace PDS.WITSMLstudio.Store.Data.Security
{
    /// <summary>
    /// Defines methods that can be used to determine if a user is authorized to execute
    /// the requested actions and has access to any requested data objects.
    /// </summary>
    public interface IUserAuthorizationProvider
    {
        /// <summary>
        /// Verifies that the current user is authorized to execute the requested ETP action.
        /// </summary>
        void CheckEtpAccess();

        /// <summary>
        /// Verifies that the current user is authorized to execute the requested SOAP action.
        /// </summary>
        void CheckSoapAccess();
    }
}
