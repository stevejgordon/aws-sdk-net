/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the ListParents operation.
    /// Lists the root or organizational units (OUs) that serve as the immediate parent of
    /// the specified child OU or account. This operation, along with <a>ListChildren</a>
    /// enables you to traverse the tree structure that makes up this root.
    /// 
    ///  <note> 
    /// <para>
    /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
    /// value when calling a <code>List*</code> operation. These operations can occasionally
    /// return an empty set of results even when there are more results available. The <code>NextToken</code>
    /// response parameter value is <code>null</code> <i>only</i> when there are no more results
    /// to display.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    ///  <note> 
    /// <para>
    /// In the current release, a child can have only a single parent. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListParentsRequest : AmazonOrganizationsRequest
    {
        private string _childId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ChildId. 
        /// <para>
        /// The unique identifier (ID) of the OU or account whose parent containers you want to
        /// list. Don't specify a root.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a child ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Account</b> - A string that consists of exactly 12 digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Organizational unit (OU)</b> - A string that begins with "ou-" followed by from
        /// 4 to 32 lowercase letters or digits (the ID of the root that contains the OU). This
        /// string is followed by a second "-" dash and from 8 to 32 additional lowercase letters
        /// or digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChildId
        {
            get { return this._childId; }
            set { this._childId = value; }
        }

        // Check to see if ChildId property is set
        internal bool IsSetChildId()
        {
            return this._childId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) Use this to limit the number of results you want included per page in the
        /// response. If you do not include this parameter, it defaults to a value that is specific
        /// to the operation. If additional items exist beyond the maximum you specify, the <code>NextToken</code>
        /// response element is present and has a value (is not null). Include that value as the
        /// <code>NextToken</code> request parameter in the next call to the operation to get
        /// the next part of the results. Note that Organizations might return fewer results than
        /// the maximum even when there are more results available. You should check <code>NextToken</code>
        /// after every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use this parameter if you receive a <code>NextToken</code> response in a previous
        /// request that indicates that there is more output available. Set it to the value of
        /// the previous call's <code>NextToken</code> response to indicate where the output should
        /// continue from.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}