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
using Amazon.CodeBuild;
using Amazon.CodeBuild.Model;

namespace Amazon.PowerShell.Cmdlets.CB
{
    /// <summary>
    /// Updates a compute fleet.
    /// </summary>
    [Cmdlet("Update", "CBFleet", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.CodeBuild.Model.Fleet")]
    [AWSCmdlet("Calls the AWS CodeBuild UpdateFleet API operation.", Operation = new[] {"UpdateFleet"}, SelectReturnType = typeof(Amazon.CodeBuild.Model.UpdateFleetResponse))]
    [AWSCmdletOutput("Amazon.CodeBuild.Model.Fleet or Amazon.CodeBuild.Model.UpdateFleetResponse",
        "This cmdlet returns an Amazon.CodeBuild.Model.Fleet object.",
        "The service call response (type Amazon.CodeBuild.Model.UpdateFleetResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateCBFleetCmdlet : AmazonCodeBuildClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter Arn
        /// <summary>
        /// <para>
        /// <para>The ARN of the compute fleet.</para>
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
        public System.String Arn { get; set; }
        #endregion
        
        #region Parameter BaseCapacity
        /// <summary>
        /// <para>
        /// <para>The initial number of machines allocated to the compute ﬂeet, which deﬁnes the number
        /// of builds that can run in parallel.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? BaseCapacity { get; set; }
        #endregion
        
        #region Parameter ComputeType
        /// <summary>
        /// <para>
        /// <para>Information about the compute resources the compute fleet uses. Available values include:</para><ul><li><para><c>BUILD_GENERAL1_SMALL</c>: Use up to 3 GB memory and 2 vCPUs for builds.</para></li><li><para><c>BUILD_GENERAL1_MEDIUM</c>: Use up to 7 GB memory and 4 vCPUs for builds.</para></li><li><para><c>BUILD_GENERAL1_LARGE</c>: Use up to 16 GB memory and 8 vCPUs for builds, depending
        /// on your environment type.</para></li><li><para><c>BUILD_GENERAL1_XLARGE</c>: Use up to 70 GB memory and 36 vCPUs for builds, depending
        /// on your environment type.</para></li><li><para><c>BUILD_GENERAL1_2XLARGE</c>: Use up to 145 GB memory, 72 vCPUs, and 824 GB of SSD
        /// storage for builds. This compute type supports Docker images up to 100 GB uncompressed.</para></li></ul><para> If you use <c>BUILD_GENERAL1_SMALL</c>: </para><ul><li><para> For environment type <c>LINUX_CONTAINER</c>, you can use up to 3 GB memory and 2
        /// vCPUs for builds. </para></li><li><para> For environment type <c>LINUX_GPU_CONTAINER</c>, you can use up to 16 GB memory,
        /// 4 vCPUs, and 1 NVIDIA A10G Tensor Core GPU for builds.</para></li><li><para> For environment type <c>ARM_CONTAINER</c>, you can use up to 4 GB memory and 2 vCPUs
        /// on ARM-based processors for builds.</para></li></ul><para> If you use <c>BUILD_GENERAL1_LARGE</c>: </para><ul><li><para> For environment type <c>LINUX_CONTAINER</c>, you can use up to 15 GB memory and 8
        /// vCPUs for builds. </para></li><li><para> For environment type <c>LINUX_GPU_CONTAINER</c>, you can use up to 255 GB memory,
        /// 32 vCPUs, and 4 NVIDIA Tesla V100 GPUs for builds.</para></li><li><para> For environment type <c>ARM_CONTAINER</c>, you can use up to 16 GB memory and 8 vCPUs
        /// on ARM-based processors for builds.</para></li></ul><para>For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// environment compute types</a> in the <i>CodeBuild User Guide.</i></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.CodeBuild.ComputeType")]
        public Amazon.CodeBuild.ComputeType ComputeType { get; set; }
        #endregion
        
        #region Parameter EnvironmentType
        /// <summary>
        /// <para>
        /// <para>The environment type of the compute fleet.</para><ul><li><para>The environment type <c>ARM_CONTAINER</c> is available only in regions US East (N.
        /// Virginia), US East (Ohio), US West (Oregon), EU (Ireland), Asia Pacific (Mumbai),
        /// Asia Pacific (Tokyo), Asia Pacific (Singapore), Asia Pacific (Sydney), EU (Frankfurt),
        /// and South America (São Paulo).</para></li><li><para>The environment type <c>LINUX_CONTAINER</c> is available only in regions US East (N.
        /// Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia Pacific
        /// (Tokyo), Asia Pacific (Singapore), Asia Pacific (Sydney), South America (São Paulo),
        /// and Asia Pacific (Mumbai).</para></li><li><para>The environment type <c>LINUX_GPU_CONTAINER</c> is available only in regions US East
        /// (N. Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt), Asia
        /// Pacific (Tokyo), and Asia Pacific (Sydney).</para></li><li><para>The environment type <c>WINDOWS_SERVER_2019_CONTAINER</c> is available only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), Asia Pacific (Sydney), Asia
        /// Pacific (Tokyo), Asia Pacific (Mumbai) and EU (Ireland).</para></li><li><para>The environment type <c>WINDOWS_SERVER_2022_CONTAINER</c> is available only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), EU (Ireland), EU (Frankfurt),
        /// Asia Pacific (Sydney), Asia Pacific (Singapore), Asia Pacific (Tokyo), South America
        /// (São Paulo) and Asia Pacific (Mumbai).</para></li></ul><para>For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// environment compute types</a> in the <i>CodeBuild user guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.CodeBuild.EnvironmentType")]
        public Amazon.CodeBuild.EnvironmentType EnvironmentType { get; set; }
        #endregion
        
        #region Parameter ScalingConfiguration_MaxCapacity
        /// <summary>
        /// <para>
        /// <para>The maximum number of instances in the ﬂeet when auto-scaling.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? ScalingConfiguration_MaxCapacity { get; set; }
        #endregion
        
        #region Parameter ScalingConfiguration_ScalingType
        /// <summary>
        /// <para>
        /// <para>The scaling type for a compute fleet.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.CodeBuild.FleetScalingType")]
        public Amazon.CodeBuild.FleetScalingType ScalingConfiguration_ScalingType { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>A list of tag key and value pairs associated with this compute fleet.</para><para>These tags are available for use by Amazon Web Services services that support CodeBuild
        /// build project tags.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.CodeBuild.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter ScalingConfiguration_TargetTrackingScalingConfig
        /// <summary>
        /// <para>
        /// <para>A list of <c>TargetTrackingScalingConfiguration</c> objects.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ScalingConfiguration_TargetTrackingScalingConfigs")]
        public Amazon.CodeBuild.Model.TargetTrackingScalingConfiguration[] ScalingConfiguration_TargetTrackingScalingConfig { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Fleet'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.CodeBuild.Model.UpdateFleetResponse).
        /// Specifying the name of a property of type Amazon.CodeBuild.Model.UpdateFleetResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Fleet";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Arn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Arn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Arn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Arn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-CBFleet (UpdateFleet)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.CodeBuild.Model.UpdateFleetResponse, UpdateCBFleetCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Arn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Arn = this.Arn;
            #if MODULAR
            if (this.Arn == null && ParameterWasBound(nameof(this.Arn)))
            {
                WriteWarning("You are passing $null as a value for parameter Arn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.BaseCapacity = this.BaseCapacity;
            context.ComputeType = this.ComputeType;
            context.EnvironmentType = this.EnvironmentType;
            context.ScalingConfiguration_MaxCapacity = this.ScalingConfiguration_MaxCapacity;
            context.ScalingConfiguration_ScalingType = this.ScalingConfiguration_ScalingType;
            if (this.ScalingConfiguration_TargetTrackingScalingConfig != null)
            {
                context.ScalingConfiguration_TargetTrackingScalingConfig = new List<Amazon.CodeBuild.Model.TargetTrackingScalingConfiguration>(this.ScalingConfiguration_TargetTrackingScalingConfig);
            }
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.CodeBuild.Model.Tag>(this.Tag);
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
            var request = new Amazon.CodeBuild.Model.UpdateFleetRequest();
            
            if (cmdletContext.Arn != null)
            {
                request.Arn = cmdletContext.Arn;
            }
            if (cmdletContext.BaseCapacity != null)
            {
                request.BaseCapacity = cmdletContext.BaseCapacity.Value;
            }
            if (cmdletContext.ComputeType != null)
            {
                request.ComputeType = cmdletContext.ComputeType;
            }
            if (cmdletContext.EnvironmentType != null)
            {
                request.EnvironmentType = cmdletContext.EnvironmentType;
            }
            
             // populate ScalingConfiguration
            var requestScalingConfigurationIsNull = true;
            request.ScalingConfiguration = new Amazon.CodeBuild.Model.ScalingConfigurationInput();
            System.Int32? requestScalingConfiguration_scalingConfiguration_MaxCapacity = null;
            if (cmdletContext.ScalingConfiguration_MaxCapacity != null)
            {
                requestScalingConfiguration_scalingConfiguration_MaxCapacity = cmdletContext.ScalingConfiguration_MaxCapacity.Value;
            }
            if (requestScalingConfiguration_scalingConfiguration_MaxCapacity != null)
            {
                request.ScalingConfiguration.MaxCapacity = requestScalingConfiguration_scalingConfiguration_MaxCapacity.Value;
                requestScalingConfigurationIsNull = false;
            }
            Amazon.CodeBuild.FleetScalingType requestScalingConfiguration_scalingConfiguration_ScalingType = null;
            if (cmdletContext.ScalingConfiguration_ScalingType != null)
            {
                requestScalingConfiguration_scalingConfiguration_ScalingType = cmdletContext.ScalingConfiguration_ScalingType;
            }
            if (requestScalingConfiguration_scalingConfiguration_ScalingType != null)
            {
                request.ScalingConfiguration.ScalingType = requestScalingConfiguration_scalingConfiguration_ScalingType;
                requestScalingConfigurationIsNull = false;
            }
            List<Amazon.CodeBuild.Model.TargetTrackingScalingConfiguration> requestScalingConfiguration_scalingConfiguration_TargetTrackingScalingConfig = null;
            if (cmdletContext.ScalingConfiguration_TargetTrackingScalingConfig != null)
            {
                requestScalingConfiguration_scalingConfiguration_TargetTrackingScalingConfig = cmdletContext.ScalingConfiguration_TargetTrackingScalingConfig;
            }
            if (requestScalingConfiguration_scalingConfiguration_TargetTrackingScalingConfig != null)
            {
                request.ScalingConfiguration.TargetTrackingScalingConfigs = requestScalingConfiguration_scalingConfiguration_TargetTrackingScalingConfig;
                requestScalingConfigurationIsNull = false;
            }
             // determine if request.ScalingConfiguration should be set to null
            if (requestScalingConfigurationIsNull)
            {
                request.ScalingConfiguration = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.CodeBuild.Model.UpdateFleetResponse CallAWSServiceOperation(IAmazonCodeBuild client, Amazon.CodeBuild.Model.UpdateFleetRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS CodeBuild", "UpdateFleet");
            try
            {
                #if DESKTOP
                return client.UpdateFleet(request);
                #elif CORECLR
                return client.UpdateFleetAsync(request).GetAwaiter().GetResult();
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
            public System.String Arn { get; set; }
            public System.Int32? BaseCapacity { get; set; }
            public Amazon.CodeBuild.ComputeType ComputeType { get; set; }
            public Amazon.CodeBuild.EnvironmentType EnvironmentType { get; set; }
            public System.Int32? ScalingConfiguration_MaxCapacity { get; set; }
            public Amazon.CodeBuild.FleetScalingType ScalingConfiguration_ScalingType { get; set; }
            public List<Amazon.CodeBuild.Model.TargetTrackingScalingConfiguration> ScalingConfiguration_TargetTrackingScalingConfig { get; set; }
            public List<Amazon.CodeBuild.Model.Tag> Tag { get; set; }
            public System.Func<Amazon.CodeBuild.Model.UpdateFleetResponse, UpdateCBFleetCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Fleet;
        }
        
    }
}
