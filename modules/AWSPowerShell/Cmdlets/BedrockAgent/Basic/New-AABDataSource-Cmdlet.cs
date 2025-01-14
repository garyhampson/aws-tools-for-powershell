/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.BedrockAgent;
using Amazon.BedrockAgent.Model;

namespace Amazon.PowerShell.Cmdlets.AAB
{
    /// <summary>
    /// Create a new data source
    /// </summary>
    [Cmdlet("New", "AABDataSource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.BedrockAgent.Model.DataSource")]
    [AWSCmdlet("Calls the Agents for Amazon Bedrock CreateDataSource API operation.", Operation = new[] {"CreateDataSource"}, SelectReturnType = typeof(Amazon.BedrockAgent.Model.CreateDataSourceResponse))]
    [AWSCmdletOutput("Amazon.BedrockAgent.Model.DataSource or Amazon.BedrockAgent.Model.CreateDataSourceResponse",
        "This cmdlet returns an Amazon.BedrockAgent.Model.DataSource object.",
        "The service call response (type Amazon.BedrockAgent.Model.CreateDataSourceResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewAABDataSourceCmdlet : AmazonBedrockAgentClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter S3Configuration_BucketArn
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("DataSourceConfiguration_S3Configuration_BucketArn")]
        public System.String S3Configuration_BucketArn { get; set; }
        #endregion
        
        #region Parameter ChunkingConfiguration_ChunkingStrategy
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("VectorIngestionConfiguration_ChunkingConfiguration_ChunkingStrategy")]
        [AWSConstantClassSource("Amazon.BedrockAgent.ChunkingStrategy")]
        public Amazon.BedrockAgent.ChunkingStrategy ChunkingConfiguration_ChunkingStrategy { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter S3Configuration_InclusionPrefix
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("DataSourceConfiguration_S3Configuration_InclusionPrefixes")]
        public System.String[] S3Configuration_InclusionPrefix { get; set; }
        #endregion
        
        #region Parameter ServerSideEncryptionConfiguration_KmsKeyArn
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ServerSideEncryptionConfiguration_KmsKeyArn { get; set; }
        #endregion
        
        #region Parameter KnowledgeBaseId
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String KnowledgeBaseId { get; set; }
        #endregion
        
        #region Parameter FixedSizeChunkingConfiguration_MaxToken
        /// <summary>
        /// <para>
        /// <para>The maximum number of tokens per chunk.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("VectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_MaxTokens")]
        public System.Int32? FixedSizeChunkingConfiguration_MaxToken { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter FixedSizeChunkingConfiguration_OverlapPercentage
        /// <summary>
        /// <para>
        /// <para>The overlap percentage between adjacent chunks.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("VectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_OverlapPercentage")]
        public System.Int32? FixedSizeChunkingConfiguration_OverlapPercentage { get; set; }
        #endregion
        
        #region Parameter DataSourceConfiguration_Type
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.BedrockAgent.DataSourceType")]
        public Amazon.BedrockAgent.DataSourceType DataSourceConfiguration_Type { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'DataSource'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.BedrockAgent.Model.CreateDataSourceResponse).
        /// Specifying the name of a property of type Amazon.BedrockAgent.Model.CreateDataSourceResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "DataSource";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the KnowledgeBaseId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^KnowledgeBaseId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^KnowledgeBaseId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.KnowledgeBaseId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-AABDataSource (CreateDataSource)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.BedrockAgent.Model.CreateDataSourceResponse, NewAABDataSourceCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.KnowledgeBaseId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientToken = this.ClientToken;
            context.S3Configuration_BucketArn = this.S3Configuration_BucketArn;
            if (this.S3Configuration_InclusionPrefix != null)
            {
                context.S3Configuration_InclusionPrefix = new List<System.String>(this.S3Configuration_InclusionPrefix);
            }
            context.DataSourceConfiguration_Type = this.DataSourceConfiguration_Type;
            #if MODULAR
            if (this.DataSourceConfiguration_Type == null && ParameterWasBound(nameof(this.DataSourceConfiguration_Type)))
            {
                WriteWarning("You are passing $null as a value for parameter DataSourceConfiguration_Type which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Description = this.Description;
            context.KnowledgeBaseId = this.KnowledgeBaseId;
            #if MODULAR
            if (this.KnowledgeBaseId == null && ParameterWasBound(nameof(this.KnowledgeBaseId)))
            {
                WriteWarning("You are passing $null as a value for parameter KnowledgeBaseId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ServerSideEncryptionConfiguration_KmsKeyArn = this.ServerSideEncryptionConfiguration_KmsKeyArn;
            context.ChunkingConfiguration_ChunkingStrategy = this.ChunkingConfiguration_ChunkingStrategy;
            context.FixedSizeChunkingConfiguration_MaxToken = this.FixedSizeChunkingConfiguration_MaxToken;
            context.FixedSizeChunkingConfiguration_OverlapPercentage = this.FixedSizeChunkingConfiguration_OverlapPercentage;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.BedrockAgent.Model.CreateDataSourceRequest();
            
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            
             // populate DataSourceConfiguration
            var requestDataSourceConfigurationIsNull = true;
            request.DataSourceConfiguration = new Amazon.BedrockAgent.Model.DataSourceConfiguration();
            Amazon.BedrockAgent.DataSourceType requestDataSourceConfiguration_dataSourceConfiguration_Type = null;
            if (cmdletContext.DataSourceConfiguration_Type != null)
            {
                requestDataSourceConfiguration_dataSourceConfiguration_Type = cmdletContext.DataSourceConfiguration_Type;
            }
            if (requestDataSourceConfiguration_dataSourceConfiguration_Type != null)
            {
                request.DataSourceConfiguration.Type = requestDataSourceConfiguration_dataSourceConfiguration_Type;
                requestDataSourceConfigurationIsNull = false;
            }
            Amazon.BedrockAgent.Model.S3DataSourceConfiguration requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration = null;
            
             // populate S3Configuration
            var requestDataSourceConfiguration_dataSourceConfiguration_S3ConfigurationIsNull = true;
            requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration = new Amazon.BedrockAgent.Model.S3DataSourceConfiguration();
            System.String requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration_s3Configuration_BucketArn = null;
            if (cmdletContext.S3Configuration_BucketArn != null)
            {
                requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration_s3Configuration_BucketArn = cmdletContext.S3Configuration_BucketArn;
            }
            if (requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration_s3Configuration_BucketArn != null)
            {
                requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration.BucketArn = requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration_s3Configuration_BucketArn;
                requestDataSourceConfiguration_dataSourceConfiguration_S3ConfigurationIsNull = false;
            }
            List<System.String> requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration_s3Configuration_InclusionPrefix = null;
            if (cmdletContext.S3Configuration_InclusionPrefix != null)
            {
                requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration_s3Configuration_InclusionPrefix = cmdletContext.S3Configuration_InclusionPrefix;
            }
            if (requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration_s3Configuration_InclusionPrefix != null)
            {
                requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration.InclusionPrefixes = requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration_s3Configuration_InclusionPrefix;
                requestDataSourceConfiguration_dataSourceConfiguration_S3ConfigurationIsNull = false;
            }
             // determine if requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration should be set to null
            if (requestDataSourceConfiguration_dataSourceConfiguration_S3ConfigurationIsNull)
            {
                requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration = null;
            }
            if (requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration != null)
            {
                request.DataSourceConfiguration.S3Configuration = requestDataSourceConfiguration_dataSourceConfiguration_S3Configuration;
                requestDataSourceConfigurationIsNull = false;
            }
             // determine if request.DataSourceConfiguration should be set to null
            if (requestDataSourceConfigurationIsNull)
            {
                request.DataSourceConfiguration = null;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.KnowledgeBaseId != null)
            {
                request.KnowledgeBaseId = cmdletContext.KnowledgeBaseId;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            
             // populate ServerSideEncryptionConfiguration
            var requestServerSideEncryptionConfigurationIsNull = true;
            request.ServerSideEncryptionConfiguration = new Amazon.BedrockAgent.Model.ServerSideEncryptionConfiguration();
            System.String requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyArn = null;
            if (cmdletContext.ServerSideEncryptionConfiguration_KmsKeyArn != null)
            {
                requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyArn = cmdletContext.ServerSideEncryptionConfiguration_KmsKeyArn;
            }
            if (requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyArn != null)
            {
                request.ServerSideEncryptionConfiguration.KmsKeyArn = requestServerSideEncryptionConfiguration_serverSideEncryptionConfiguration_KmsKeyArn;
                requestServerSideEncryptionConfigurationIsNull = false;
            }
             // determine if request.ServerSideEncryptionConfiguration should be set to null
            if (requestServerSideEncryptionConfigurationIsNull)
            {
                request.ServerSideEncryptionConfiguration = null;
            }
            
             // populate VectorIngestionConfiguration
            var requestVectorIngestionConfigurationIsNull = true;
            request.VectorIngestionConfiguration = new Amazon.BedrockAgent.Model.VectorIngestionConfiguration();
            Amazon.BedrockAgent.Model.ChunkingConfiguration requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration = null;
            
             // populate ChunkingConfiguration
            var requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfigurationIsNull = true;
            requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration = new Amazon.BedrockAgent.Model.ChunkingConfiguration();
            Amazon.BedrockAgent.ChunkingStrategy requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_chunkingConfiguration_ChunkingStrategy = null;
            if (cmdletContext.ChunkingConfiguration_ChunkingStrategy != null)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_chunkingConfiguration_ChunkingStrategy = cmdletContext.ChunkingConfiguration_ChunkingStrategy;
            }
            if (requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_chunkingConfiguration_ChunkingStrategy != null)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration.ChunkingStrategy = requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_chunkingConfiguration_ChunkingStrategy;
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfigurationIsNull = false;
            }
            Amazon.BedrockAgent.Model.FixedSizeChunkingConfiguration requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration = null;
            
             // populate FixedSizeChunkingConfiguration
            var requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfigurationIsNull = true;
            requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration = new Amazon.BedrockAgent.Model.FixedSizeChunkingConfiguration();
            System.Int32? requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_fixedSizeChunkingConfiguration_MaxToken = null;
            if (cmdletContext.FixedSizeChunkingConfiguration_MaxToken != null)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_fixedSizeChunkingConfiguration_MaxToken = cmdletContext.FixedSizeChunkingConfiguration_MaxToken.Value;
            }
            if (requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_fixedSizeChunkingConfiguration_MaxToken != null)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration.MaxTokens = requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_fixedSizeChunkingConfiguration_MaxToken.Value;
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfigurationIsNull = false;
            }
            System.Int32? requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_fixedSizeChunkingConfiguration_OverlapPercentage = null;
            if (cmdletContext.FixedSizeChunkingConfiguration_OverlapPercentage != null)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_fixedSizeChunkingConfiguration_OverlapPercentage = cmdletContext.FixedSizeChunkingConfiguration_OverlapPercentage.Value;
            }
            if (requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_fixedSizeChunkingConfiguration_OverlapPercentage != null)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration.OverlapPercentage = requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration_fixedSizeChunkingConfiguration_OverlapPercentage.Value;
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfigurationIsNull = false;
            }
             // determine if requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration should be set to null
            if (requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfigurationIsNull)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration = null;
            }
            if (requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration != null)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration.FixedSizeChunkingConfiguration = requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_vectorIngestionConfiguration_ChunkingConfiguration_FixedSizeChunkingConfiguration;
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfigurationIsNull = false;
            }
             // determine if requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration should be set to null
            if (requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfigurationIsNull)
            {
                requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration = null;
            }
            if (requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration != null)
            {
                request.VectorIngestionConfiguration.ChunkingConfiguration = requestVectorIngestionConfiguration_vectorIngestionConfiguration_ChunkingConfiguration;
                requestVectorIngestionConfigurationIsNull = false;
            }
             // determine if request.VectorIngestionConfiguration should be set to null
            if (requestVectorIngestionConfigurationIsNull)
            {
                request.VectorIngestionConfiguration = null;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.BedrockAgent.Model.CreateDataSourceResponse CallAWSServiceOperation(IAmazonBedrockAgent client, Amazon.BedrockAgent.Model.CreateDataSourceRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Agents for Amazon Bedrock", "CreateDataSource");
            try
            {
                #if DESKTOP
                return client.CreateDataSource(request);
                #elif CORECLR
                return client.CreateDataSourceAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String ClientToken { get; set; }
            public System.String S3Configuration_BucketArn { get; set; }
            public List<System.String> S3Configuration_InclusionPrefix { get; set; }
            public Amazon.BedrockAgent.DataSourceType DataSourceConfiguration_Type { get; set; }
            public System.String Description { get; set; }
            public System.String KnowledgeBaseId { get; set; }
            public System.String Name { get; set; }
            public System.String ServerSideEncryptionConfiguration_KmsKeyArn { get; set; }
            public Amazon.BedrockAgent.ChunkingStrategy ChunkingConfiguration_ChunkingStrategy { get; set; }
            public System.Int32? FixedSizeChunkingConfiguration_MaxToken { get; set; }
            public System.Int32? FixedSizeChunkingConfiguration_OverlapPercentage { get; set; }
            public System.Func<Amazon.BedrockAgent.Model.CreateDataSourceResponse, NewAABDataSourceCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.DataSource;
        }
        
    }
}
