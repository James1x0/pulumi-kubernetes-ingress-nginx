// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.KubernetesIngressNginx.Inputs
{

    public sealed class ControllerDefaultBackendArgs : global::Pulumi.ResourceArgs
    {
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.AffinityArgs>? Affinity { get; set; }

        [Input("autoscaling")]
        public Input<Inputs.AutoscalingArgs>? Autoscaling { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Use an existing PSP instead of creating one.
        /// </summary>
        [Input("existingPsp")]
        public Input<string>? ExistingPsp { get; set; }

        [Input("extraArgs")]
        private InputMap<ImmutableDictionary<string, string>>? _extraArgs;
        public InputMap<ImmutableDictionary<string, string>> ExtraArgs
        {
            get => _extraArgs ?? (_extraArgs = new InputMap<ImmutableDictionary<string, string>>());
            set => _extraArgs = value;
        }

        [Input("extraEnvs")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.EnvVarArgs>? _extraEnvs;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.EnvVarArgs> ExtraEnvs
        {
            get => _extraEnvs ?? (_extraEnvs = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.EnvVarArgs>());
            set => _extraEnvs = value;
        }

        [Input("extraVolumeMounts")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeMountArgs>? _extraVolumeMounts;

        /// <summary>
        /// Additional volumeMounts to the default backend container.  - name: copy-portal-skins    mountPath: /var/lib/lemonldap-ng/portal/skins
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeMountArgs> ExtraVolumeMounts
        {
            get => _extraVolumeMounts ?? (_extraVolumeMounts = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeMountArgs>());
            set => _extraVolumeMounts = value;
        }

        [Input("extraVolumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeArgs>? _extraVolumes;

        /// <summary>
        /// Additional volumes to the default backend pod.  - name: copy-portal-skins    emptyDir: {}
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeArgs> ExtraVolumes
        {
            get => _extraVolumes ?? (_extraVolumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeArgs>());
            set => _extraVolumes = value;
        }

        [Input("image")]
        public Input<Inputs.ControllerImageArgs>? Image { get; set; }

        /// <summary>
        /// Liveness probe values for default backend. Ref: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#container-probes.
        /// </summary>
        [Input("livenessProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ProbeArgs>? LivenessProbe { get; set; }

        [Input("minAvailable")]
        public Input<int>? MinAvailable { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("nodeSelector")]
        private InputMap<string>? _nodeSelector;

        /// <summary>
        /// Node labels for default backend pod assignment Ref: https://kubernetes.io/docs/user-guide/node-selection/.
        /// </summary>
        public InputMap<string> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<string>());
            set => _nodeSelector = value;
        }

        [Input("podAnnotations")]
        private InputMap<string>? _podAnnotations;

        /// <summary>
        /// Annotations to be added to default backend pods.
        /// </summary>
        public InputMap<string> PodAnnotations
        {
            get => _podAnnotations ?? (_podAnnotations = new InputMap<string>());
            set => _podAnnotations = value;
        }

        [Input("podLabels")]
        private InputMap<string>? _podLabels;

        /// <summary>
        /// labels to add to the pod container metadata
        /// </summary>
        public InputMap<string> PodLabels
        {
            get => _podLabels ?? (_podLabels = new InputMap<string>());
            set => _podLabels = value;
        }

        /// <summary>
        /// Security Context policies for controller pods. See https://kubernetes.io/docs/tasks/administer-cluster/sysctl-cluster/ for notes on enabling and using sysctls.
        /// </summary>
        [Input("podSecurityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PodSecurityContextArgs>? PodSecurityContext { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("priorityClassName")]
        public Input<string>? PriorityClassName { get; set; }

        /// <summary>
        /// Readiness probe values for default backend. Ref: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#container-probes.
        /// </summary>
        [Input("readinessProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ProbeArgs>? ReadinessProbe { get; set; }

        [Input("replicaCount")]
        public Input<int>? ReplicaCount { get; set; }

        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ResourceRequirementsArgs>? Resources { get; set; }

        [Input("service")]
        public Input<Inputs.ControllerDefaultBackendServiceArgs>? Service { get; set; }

        [Input("serviceAccount")]
        public Input<Inputs.ControllerServiceAccountArgs>? ServiceAccount { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TolerationArgs>? _tolerations;

        /// <summary>
        /// Node tolerations for server scheduling to nodes with taints. Ref: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TolerationArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TolerationArgs>());
            set => _tolerations = value;
        }

        public ControllerDefaultBackendArgs()
        {
        }
        public static new ControllerDefaultBackendArgs Empty => new ControllerDefaultBackendArgs();
    }
}
