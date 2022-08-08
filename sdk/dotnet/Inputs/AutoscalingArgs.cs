// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.KubernetesIngressNginx.Inputs
{

    public sealed class AutoscalingArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("controllerAutoscalingBehavior")]
        public Input<Inputs.AutoscalingBehaviorArgs>? ControllerAutoscalingBehavior { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("maxReplicas")]
        public Input<int>? MaxReplicas { get; set; }

        [Input("minReplicas")]
        public Input<int>? MinReplicas { get; set; }

        [Input("targetCPUUtilizationPercentage")]
        public Input<int>? TargetCPUUtilizationPercentage { get; set; }

        [Input("targetMemoryUtilizationPercentage")]
        public Input<int>? TargetMemoryUtilizationPercentage { get; set; }

        public AutoscalingArgs()
        {
        }
        public static new AutoscalingArgs Empty => new AutoscalingArgs();
    }
}
