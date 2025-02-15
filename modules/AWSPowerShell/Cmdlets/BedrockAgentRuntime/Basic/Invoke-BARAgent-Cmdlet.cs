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
using Amazon.BedrockAgentRuntime;
using Amazon.BedrockAgentRuntime.Model;

namespace Amazon.PowerShell.Cmdlets.BAR
{
    /// <summary>
    /// Invokes the specified Bedrock model to run inference using the input provided in the
    /// request body.
    /// </summary>
    [Cmdlet("Invoke", "BARAgent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse")]
    [AWSCmdlet("Calls the Amazon Bedrock Agent Runtime InvokeAgent API operation.", Operation = new[] {"InvokeAgent"}, SelectReturnType = typeof(Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse))]
    [AWSCmdletOutput("Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse",
        "This cmdlet returns an Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class InvokeBARAgentCmdlet : AmazonBedrockAgentRuntimeClientCmdlet, IExecutor
    {
        
        protected override bool IsSensitiveRequest { get; set; } = true;
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter AgentAliasId
        /// <summary>
        /// <para>
        /// <para>Identifier for Agent Alias</para>
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
        public System.String AgentAliasId { get; set; }
        #endregion
        
        #region Parameter AgentId
        /// <summary>
        /// <para>
        /// <para>Identifier for Agent</para>
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
        
        #region Parameter EnableTrace
        /// <summary>
        /// <para>
        /// <para>Enable agent trace events for improved debugging</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EnableTrace { get; set; }
        #endregion
        
        #region Parameter EndSession
        /// <summary>
        /// <para>
        /// <para>End current session</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EndSession { get; set; }
        #endregion
        
        #region Parameter InputText
        /// <summary>
        /// <para>
        /// <para>Input data in the format specified in the Content-Type request header.</para>
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
        public System.String InputText { get; set; }
        #endregion
        
        #region Parameter SessionState_PromptSessionAttribute
        /// <summary>
        /// <para>
        /// <para>Prompt Session Attributes</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SessionState_PromptSessionAttributes")]
        public System.Collections.Hashtable SessionState_PromptSessionAttribute { get; set; }
        #endregion
        
        #region Parameter SessionState_SessionAttribute
        /// <summary>
        /// <para>
        /// <para>Session Attributes</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SessionState_SessionAttributes")]
        public System.Collections.Hashtable SessionState_SessionAttribute { get; set; }
        #endregion
        
        #region Parameter SessionId
        /// <summary>
        /// <para>
        /// <para>Identifier used for the current session</para>
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
        public System.String SessionId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse).
        /// Specifying the name of a property of type Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Invoke-BARAgent (InvokeAgent)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse, InvokeBARAgentCmdlet>(Select) ??
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
            context.AgentAliasId = this.AgentAliasId;
            #if MODULAR
            if (this.AgentAliasId == null && ParameterWasBound(nameof(this.AgentAliasId)))
            {
                WriteWarning("You are passing $null as a value for parameter AgentAliasId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AgentId = this.AgentId;
            #if MODULAR
            if (this.AgentId == null && ParameterWasBound(nameof(this.AgentId)))
            {
                WriteWarning("You are passing $null as a value for parameter AgentId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.EnableTrace = this.EnableTrace;
            context.EndSession = this.EndSession;
            context.InputText = this.InputText;
            #if MODULAR
            if (this.InputText == null && ParameterWasBound(nameof(this.InputText)))
            {
                WriteWarning("You are passing $null as a value for parameter InputText which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SessionId = this.SessionId;
            #if MODULAR
            if (this.SessionId == null && ParameterWasBound(nameof(this.SessionId)))
            {
                WriteWarning("You are passing $null as a value for parameter SessionId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.SessionState_PromptSessionAttribute != null)
            {
                context.SessionState_PromptSessionAttribute = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.SessionState_PromptSessionAttribute.Keys)
                {
                    context.SessionState_PromptSessionAttribute.Add((String)hashKey, (System.String)(this.SessionState_PromptSessionAttribute[hashKey]));
                }
            }
            if (this.SessionState_SessionAttribute != null)
            {
                context.SessionState_SessionAttribute = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.SessionState_SessionAttribute.Keys)
                {
                    context.SessionState_SessionAttribute.Add((String)hashKey, (System.String)(this.SessionState_SessionAttribute[hashKey]));
                }
            }
            
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
            var request = new Amazon.BedrockAgentRuntime.Model.InvokeAgentRequest();
            
            if (cmdletContext.AgentAliasId != null)
            {
                request.AgentAliasId = cmdletContext.AgentAliasId;
            }
            if (cmdletContext.AgentId != null)
            {
                request.AgentId = cmdletContext.AgentId;
            }
            if (cmdletContext.EnableTrace != null)
            {
                request.EnableTrace = cmdletContext.EnableTrace.Value;
            }
            if (cmdletContext.EndSession != null)
            {
                request.EndSession = cmdletContext.EndSession.Value;
            }
            if (cmdletContext.InputText != null)
            {
                request.InputText = cmdletContext.InputText;
            }
            if (cmdletContext.SessionId != null)
            {
                request.SessionId = cmdletContext.SessionId;
            }
            
             // populate SessionState
            var requestSessionStateIsNull = true;
            request.SessionState = new Amazon.BedrockAgentRuntime.Model.SessionState();
            Dictionary<System.String, System.String> requestSessionState_sessionState_PromptSessionAttribute = null;
            if (cmdletContext.SessionState_PromptSessionAttribute != null)
            {
                requestSessionState_sessionState_PromptSessionAttribute = cmdletContext.SessionState_PromptSessionAttribute;
            }
            if (requestSessionState_sessionState_PromptSessionAttribute != null)
            {
                request.SessionState.PromptSessionAttributes = requestSessionState_sessionState_PromptSessionAttribute;
                requestSessionStateIsNull = false;
            }
            Dictionary<System.String, System.String> requestSessionState_sessionState_SessionAttribute = null;
            if (cmdletContext.SessionState_SessionAttribute != null)
            {
                requestSessionState_sessionState_SessionAttribute = cmdletContext.SessionState_SessionAttribute;
            }
            if (requestSessionState_sessionState_SessionAttribute != null)
            {
                request.SessionState.SessionAttributes = requestSessionState_sessionState_SessionAttribute;
                requestSessionStateIsNull = false;
            }
             // determine if request.SessionState should be set to null
            if (requestSessionStateIsNull)
            {
                request.SessionState = null;
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
        
        private Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse CallAWSServiceOperation(IAmazonBedrockAgentRuntime client, Amazon.BedrockAgentRuntime.Model.InvokeAgentRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Bedrock Agent Runtime", "InvokeAgent");
            try
            {
                #if DESKTOP
                return client.InvokeAgent(request);
                #elif CORECLR
                return client.InvokeAgentAsync(request).GetAwaiter().GetResult();
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
            public System.String AgentAliasId { get; set; }
            public System.String AgentId { get; set; }
            public System.Boolean? EnableTrace { get; set; }
            public System.Boolean? EndSession { get; set; }
            public System.String InputText { get; set; }
            public System.String SessionId { get; set; }
            public Dictionary<System.String, System.String> SessionState_PromptSessionAttribute { get; set; }
            public Dictionary<System.String, System.String> SessionState_SessionAttribute { get; set; }
            public System.Func<Amazon.BedrockAgentRuntime.Model.InvokeAgentResponse, InvokeBARAgentCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
