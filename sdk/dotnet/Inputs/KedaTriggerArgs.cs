// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.KubernetesIngressNginx.Inputs
{

    public sealed class KedaTriggerArgs : global::Pulumi.ResourceArgs
    {
        [Input("metadata")]
        private InputMap<ImmutableDictionary<string, string>>? _metadata;
        public InputMap<ImmutableDictionary<string, string>> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<ImmutableDictionary<string, string>>());
            set => _metadata = value;
        }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public KedaTriggerArgs()
        {
        }
        public static new KedaTriggerArgs Empty => new KedaTriggerArgs();
    }
}
