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
    /// Creates an Action Group for existing Amazon Bedrock Agent
    /// </summary>
    [Cmdlet("New", "AABAgentActionGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.BedrockAgent.Model.AgentActionGroup")]
    [AWSCmdlet("Calls the Agents for Amazon Bedrock CreateAgentActionGroup API operation.", Operation = new[] {"CreateAgentActionGroup"}, SelectReturnType = typeof(Amazon.BedrockAgent.Model.CreateAgentActionGroupResponse))]
    [AWSCmdletOutput("Amazon.BedrockAgent.Model.AgentActionGroup or Amazon.BedrockAgent.Model.CreateAgentActionGroupResponse",
        "This cmdlet returns an Amazon.BedrockAgent.Model.AgentActionGroup object.",
        "The service call response (type Amazon.BedrockAgent.Model.CreateAgentActionGroupResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewAABAgentActionGroupCmdlet : AmazonBedrockAgentClientCmdlet, IExecutor
    {
        
        protected override bool IsSensitiveRequest { get; set; } = true;
        
        protected override bool IsSensitiveResponse { get; set; } = true;
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter ActionGroupName
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
        public System.String ActionGroupName { get; set; }
        #endregion
        
        #region Parameter ActionGroupState
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.BedrockAgent.ActionGroupState")]
        public Amazon.BedrockAgent.ActionGroupState ActionGroupState { get; set; }
        #endregion
        
        #region Parameter AgentId
        /// <summary>
        /// <para>
        /// <para>Id generated at the server side when an Agent is created</para>
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
        public System.String AgentId { get; set; }
        #endregion
        
        #region Parameter AgentVersion
        /// <summary>
        /// <para>
        /// <para>Draft Version of the Agent.</para>
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
        public System.String AgentVersion { get; set; }
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
        
        #region Parameter ActionGroupExecutor_Lambda
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ActionGroupExecutor_Lambda { get; set; }
        #endregion
        
        #region Parameter ParentActionGroupSignature
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.BedrockAgent.ActionGroupSignature")]
        public Amazon.BedrockAgent.ActionGroupSignature ParentActionGroupSignature { get; set; }
        #endregion
        
        #region Parameter ApiSchema_Payload
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ApiSchema_Payload { get; set; }
        #endregion
        
        #region Parameter S3_S3BucketName
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ApiSchema_S3_S3BucketName")]
        public System.String S3_S3BucketName { get; set; }
        #endregion
        
        #region Parameter S3_S3ObjectKey
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ApiSchema_S3_S3ObjectKey")]
        public System.String S3_S3ObjectKey { get; set; }
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
        /// Use the -Select parameter to control the cmdlet output. The default value is 'AgentActionGroup'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.BedrockAgent.Model.CreateAgentActionGroupResponse).
        /// Specifying the name of a property of type Amazon.BedrockAgent.Model.CreateAgentActionGroupResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "AgentActionGroup";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AgentId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AgentId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AgentId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AgentId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-AABAgentActionGroup (CreateAgentActionGroup)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.BedrockAgent.Model.CreateAgentActionGroupResponse, NewAABAgentActionGroupCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AgentId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ActionGroupExecutor_Lambda = this.ActionGroupExecutor_Lambda;
            context.ActionGroupName = this.ActionGroupName;
            #if MODULAR
            if (this.ActionGroupName == null && ParameterWasBound(nameof(this.ActionGroupName)))
            {
                WriteWarning("You are passing $null as a value for parameter ActionGroupName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ActionGroupState = this.ActionGroupState;
            context.AgentId = this.AgentId;
            #if MODULAR
            if (this.AgentId == null && ParameterWasBound(nameof(this.AgentId)))
            {
                WriteWarning("You are passing $null as a value for parameter AgentId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AgentVersion = this.AgentVersion;
            #if MODULAR
            if (this.AgentVersion == null && ParameterWasBound(nameof(this.AgentVersion)))
            {
                WriteWarning("You are passing $null as a value for parameter AgentVersion which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ApiSchema_Payload = this.ApiSchema_Payload;
            context.S3_S3BucketName = this.S3_S3BucketName;
            context.S3_S3ObjectKey = this.S3_S3ObjectKey;
            context.ClientToken = this.ClientToken;
            context.Description = this.Description;
            context.ParentActionGroupSignature = this.ParentActionGroupSignature;
            
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
            var request = new Amazon.BedrockAgent.Model.CreateAgentActionGroupRequest();
            
            
             // populate ActionGroupExecutor
            var requestActionGroupExecutorIsNull = true;
            request.ActionGroupExecutor = new Amazon.BedrockAgent.Model.ActionGroupExecutor();
            System.String requestActionGroupExecutor_actionGroupExecutor_Lambda = null;
            if (cmdletContext.ActionGroupExecutor_Lambda != null)
            {
                requestActionGroupExecutor_actionGroupExecutor_Lambda = cmdletContext.ActionGroupExecutor_Lambda;
            }
            if (requestActionGroupExecutor_actionGroupExecutor_Lambda != null)
            {
                request.ActionGroupExecutor.Lambda = requestActionGroupExecutor_actionGroupExecutor_Lambda;
                requestActionGroupExecutorIsNull = false;
            }
             // determine if request.ActionGroupExecutor should be set to null
            if (requestActionGroupExecutorIsNull)
            {
                request.ActionGroupExecutor = null;
            }
            if (cmdletContext.ActionGroupName != null)
            {
                request.ActionGroupName = cmdletContext.ActionGroupName;
            }
            if (cmdletContext.ActionGroupState != null)
            {
                request.ActionGroupState = cmdletContext.ActionGroupState;
            }
            if (cmdletContext.AgentId != null)
            {
                request.AgentId = cmdletContext.AgentId;
            }
            if (cmdletContext.AgentVersion != null)
            {
                request.AgentVersion = cmdletContext.AgentVersion;
            }
            
             // populate ApiSchema
            var requestApiSchemaIsNull = true;
            request.ApiSchema = new Amazon.BedrockAgent.Model.APISchema();
            System.String requestApiSchema_apiSchema_Payload = null;
            if (cmdletContext.ApiSchema_Payload != null)
            {
                requestApiSchema_apiSchema_Payload = cmdletContext.ApiSchema_Payload;
            }
            if (requestApiSchema_apiSchema_Payload != null)
            {
                request.ApiSchema.Payload = requestApiSchema_apiSchema_Payload;
                requestApiSchemaIsNull = false;
            }
            Amazon.BedrockAgent.Model.S3Identifier requestApiSchema_apiSchema_S3 = null;
            
             // populate S3
            var requestApiSchema_apiSchema_S3IsNull = true;
            requestApiSchema_apiSchema_S3 = new Amazon.BedrockAgent.Model.S3Identifier();
            System.String requestApiSchema_apiSchema_S3_s3_S3BucketName = null;
            if (cmdletContext.S3_S3BucketName != null)
            {
                requestApiSchema_apiSchema_S3_s3_S3BucketName = cmdletContext.S3_S3BucketName;
            }
            if (requestApiSchema_apiSchema_S3_s3_S3BucketName != null)
            {
                requestApiSchema_apiSchema_S3.S3BucketName = requestApiSchema_apiSchema_S3_s3_S3BucketName;
                requestApiSchema_apiSchema_S3IsNull = false;
            }
            System.String requestApiSchema_apiSchema_S3_s3_S3ObjectKey = null;
            if (cmdletContext.S3_S3ObjectKey != null)
            {
                requestApiSchema_apiSchema_S3_s3_S3ObjectKey = cmdletContext.S3_S3ObjectKey;
            }
            if (requestApiSchema_apiSchema_S3_s3_S3ObjectKey != null)
            {
                requestApiSchema_apiSchema_S3.S3ObjectKey = requestApiSchema_apiSchema_S3_s3_S3ObjectKey;
                requestApiSchema_apiSchema_S3IsNull = false;
            }
             // determine if requestApiSchema_apiSchema_S3 should be set to null
            if (requestApiSchema_apiSchema_S3IsNull)
            {
                requestApiSchema_apiSchema_S3 = null;
            }
            if (requestApiSchema_apiSchema_S3 != null)
            {
                request.ApiSchema.S3 = requestApiSchema_apiSchema_S3;
                requestApiSchemaIsNull = false;
            }
             // determine if request.ApiSchema should be set to null
            if (requestApiSchemaIsNull)
            {
                request.ApiSchema = null;
            }
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.ParentActionGroupSignature != null)
            {
                request.ParentActionGroupSignature = cmdletContext.ParentActionGroupSignature;
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
        
        private Amazon.BedrockAgent.Model.CreateAgentActionGroupResponse CallAWSServiceOperation(IAmazonBedrockAgent client, Amazon.BedrockAgent.Model.CreateAgentActionGroupRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Agents for Amazon Bedrock", "CreateAgentActionGroup");
            try
            {
                #if DESKTOP
                return client.CreateAgentActionGroup(request);
                #elif CORECLR
                return client.CreateAgentActionGroupAsync(request).GetAwaiter().GetResult();
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
            public System.String ActionGroupExecutor_Lambda { get; set; }
            public System.String ActionGroupName { get; set; }
            public Amazon.BedrockAgent.ActionGroupState ActionGroupState { get; set; }
            public System.String AgentId { get; set; }
            public System.String AgentVersion { get; set; }
            public System.String ApiSchema_Payload { get; set; }
            public System.String S3_S3BucketName { get; set; }
            public System.String S3_S3ObjectKey { get; set; }
            public System.String ClientToken { get; set; }
            public System.String Description { get; set; }
            public Amazon.BedrockAgent.ActionGroupSignature ParentActionGroupSignature { get; set; }
            public System.Func<Amazon.BedrockAgent.Model.CreateAgentActionGroupResponse, NewAABAgentActionGroupCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.AgentActionGroup;
        }
        
    }
}
