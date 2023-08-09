// This file is auto-generated
namespace fn.OpenXR.Common
{
    [StructLayout(LayoutKind.Sequential)]
    struct XrApiLayerProperties
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        char[] layerName = new char[XR_MAX_API_LAYER_NAME_SIZ];
    
        XrVersion specVersion;
    
        uint layerVersion;
    
        char[] description = new char[XR_MAX_API_LAYER_DESCRIPTION_SIZ];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrExtensionProperties
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        char[] extensionName = new char[XR_MAX_EXTENSION_NAME_SIZ];
    
        uint extensionVersion;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrApplicationInfo
    {
    
        char[] applicationName = new char[XR_MAX_APPLICATION_NAME_SIZ];
    
        uint applicationVersion;
    
        char[] engineName = new char[XR_MAX_ENGINE_NAME_SIZ];
    
        uint engineVersion;
    
        XrVersion apiVersion;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInstanceCreateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrInstanceCreateFlags createFlags;
    
        XrApplicationInfo applicationInfo;
    
        uint enabledApiLayerCount;
    
        IntPtr enabledApiLayerNames;
    
        uint enabledExtensionCount;
    
        IntPtr enabledExtensionNames;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInstanceProperties
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrVersion runtimeVersion;
    
        char[] runtimeName = new char[XR_MAX_RUNTIME_NAME_SIZ];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataBuffer
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint8_t[] varying = new uint8_t[400];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemGetInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrFormFactor formFactor;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemGraphicsProperties
    {
    
        uint maxSwapchainImageHeight;
    
        uint maxSwapchainImageWidth;
    
        uint maxLayerCount;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemTrackingProperties
    {
    
        uint orientationTracking;
    
        uint positionTracking;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemProperties
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSystemId systemId;
    
        uint vendorId;
    
        char[] systemName = new char[XR_MAX_SYSTEM_NAME_SIZ];
    
        XrSystemGraphicsProperties graphicsProperties;
    
        XrSystemTrackingProperties trackingProperties;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSessionCreateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSessionCreateFlags createFlags;
    
        XrSystemId systemId;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVector3f
    {
    
        float x;
    
        float y;
    
        float z;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceVelocity
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpaceVelocityFlags velocityFlags;
    
        XrVector3f linearVelocity;
    
        XrVector3f angularVelocity;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrQuaternionf
    {
    
        float x;
    
        float y;
    
        float z;
    
        float w;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPosef
    {
    
        XrQuaternionf orientation;
    
        XrVector3f position;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrReferenceSpaceCreateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrReferenceSpaceType referenceSpaceType;
    
        XrPosef poseInReferenceSpace;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrExtent2Df
    {
    
        float width;
    
        float height;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionSpaceCreateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAction action;
    
        XrPath subactionPath;
    
        XrPosef poseInActionSpace;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceLocation
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpaceLocationFlags locationFlags;
    
        XrPosef pose;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewConfigurationProperties
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrViewConfigurationType viewConfigurationType;
    
        uint fovMutable;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewConfigurationView
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint recommendedImageRectWidth;
    
        uint maxImageRectWidth;
    
        uint recommendedImageRectHeight;
    
        uint maxImageRectHeight;
    
        uint recommendedSwapchainSampleCount;
    
        uint maxSwapchainSampleCount;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainCreateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSwapchainCreateFlags createFlags;
    
        XrSwapchainUsageFlags usageFlags;
    
        int64_t format;
    
        uint sampleCount;
    
        uint width;
    
        uint height;
    
        uint faceCount;
    
        uint arraySize;
    
        uint mipCount;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainImageBaseHeader
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainImageAcquireInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainImageWaitInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrDuration timeout;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainImageReleaseInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSessionBeginInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrViewConfigurationType primaryViewConfigurationType;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFrameWaitInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFrameState
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrTime predictedDisplayTime;
    
        XrDuration predictedDisplayPeriod;
    
        uint shouldRender;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFrameBeginInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerBaseHeader
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags layerFlags;
    
        XrSpace space;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFrameEndInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrTime displayTime;
    
        XrEnvironmentBlendMode environmentBlendMode;
    
        uint layerCount;
    
        IntPtr layers;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewLocateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrViewConfigurationType viewConfigurationType;
    
        XrTime displayTime;
    
        XrSpace space;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewState
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrViewStateFlags viewStateFlags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFovf
    {
    
        float angleLeft;
    
        float angleRight;
    
        float angleUp;
    
        float angleDown;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrView
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPosef pose;
    
        XrFovf fov;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionSetCreateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        char[] actionSetName = new char[XR_MAX_ACTION_SET_NAME_SIZ];
    
        char[] localizedActionSetName = new char[XR_MAX_LOCALIZED_ACTION_SET_NAME_SIZ];
    
        uint priority;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionCreateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        char[] actionName = new char[XR_MAX_ACTION_NAME_SIZ];
    
        XrActionType actionType;
    
        uint countSubactionPaths;
    
        IntPtr subactionPaths;
    
        char[] localizedActionName = new char[XR_MAX_LOCALIZED_ACTION_NAME_SIZ];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionSuggestedBinding
    {
    
        XrAction action;
    
        XrPath binding;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInteractionProfileSuggestedBinding
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPath interactionProfile;
    
        uint countSuggestedBindings;
    
        IntPtr suggestedBindings;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSessionActionSetsAttachInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint countActionSets;
    
        IntPtr actionSets;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInteractionProfileState
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPath interactionProfile;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStateGetInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAction action;
    
        XrPath subactionPath;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStateBoolean
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint currentState;
    
        uint changedSinceLastSync;
    
        XrTime lastChangeTime;
    
        uint isActive;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStateFloat
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float currentState;
    
        uint changedSinceLastSync;
    
        XrTime lastChangeTime;
    
        uint isActive;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVector2f
    {
    
        float x;
    
        float y;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStateVector2f
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrVector2f currentState;
    
        uint changedSinceLastSync;
    
        XrTime lastChangeTime;
    
        uint isActive;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStatePose
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint isActive;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActiveActionSet
    {
    
        XrActionSet actionSet;
    
        XrPath subactionPath;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionsSyncInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint countActiveActionSets;
    
        IntPtr activeActionSets;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBoundSourcesForActionEnumerateInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAction action;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInputSourceLocalizedNameGetInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPath sourcePath;
    
        XrInputSourceLocalizedNameFlags whichComponents;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHapticActionInfo
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAction action;
    
        XrPath subactionPath;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHapticBaseHeader
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBaseInStructure
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBaseOutStructure
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrOffset2Di
    {
    
        int32_t x;
    
        int32_t y;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrExtent2Di
    {
    
        int32_t width;
    
        int32_t height;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRect2Di
    {
    
        XrOffset2Di offset;
    
        XrExtent2Di extent;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainSubImage
    {
    
        XrSwapchain swapchain;
    
        XrRect2Di imageRect;
    
        uint imageArrayIndex;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerProjectionView
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPosef pose;
    
        XrFovf fov;
    
        XrSwapchainSubImage subImage;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerProjection
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags layerFlags;
    
        XrSpace space;
    
        uint viewCount;
    
        IntPtr views;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerQuad
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags layerFlags;
    
        XrSpace space;
    
        XrEyeVisibility eyeVisibility;
    
        XrSwapchainSubImage subImage;
    
        XrPosef pose;
    
        XrExtent2Df size;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataBaseHeader
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataEventsLost
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint lostEventCount;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataInstanceLossPending
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrTime lossTime;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSessionStateChanged
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSession session;
    
        XrSessionState state;
    
        XrTime time;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataReferenceSpaceChangePending
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSession session;
    
        XrReferenceSpaceType referenceSpaceType;
    
        XrTime changeTime;
    
        uint poseValid;
    
        XrPosef poseInPreviousSpace;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataInteractionProfileChanged
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSession session;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHapticVibration
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrDuration duration;
    
        float frequency;
    
        float amplitude;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrOffset2Df
    {
    
        float x;
    
        float y;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRect2Df
    {
    
        XrOffset2Df offset;
    
        XrExtent2Df extent;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVector4f
    {
    
        float x;
    
        float y;
    
        float z;
    
        float w;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrColor4f
    {
    
        float r;
    
        float g;
    
        float b;
    
        float a;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerCubeKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags layerFlags;
    
        XrSpace space;
    
        XrEyeVisibility eyeVisibility;
    
        XrSwapchain swapchain;
    
        uint imageArrayIndex;
    
        XrQuaternionf orientation;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerDepthInfoKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSwapchainSubImage subImage;
    
        float minDepth;
    
        float maxDepth;
    
        float nearZ;
    
        float farZ;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerCylinderKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags layerFlags;
    
        XrSpace space;
    
        XrEyeVisibility eyeVisibility;
    
        XrSwapchainSubImage subImage;
    
        XrPosef pose;
    
        float radius;
    
        float centralAngle;
    
        float aspectRatio;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerEquirectKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags layerFlags;
    
        XrSpace space;
    
        XrEyeVisibility eyeVisibility;
    
        XrSwapchainSubImage subImage;
    
        XrPosef pose;
    
        float radius;
    
        XrVector2f scale;
    
        XrVector2f bias;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVisibilityMaskKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint vertexCapacityInput;
    
        uint vertexCountOutput;
    
        IntPtr vertices;
    
        uint indexCapacityInput;
    
        uint indexCountOutput;
    
        IntPtr indices;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataVisibilityMaskChangedKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSession session;
    
        XrViewConfigurationType viewConfigurationType;
    
        uint viewIndex;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerColorScaleBiasKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrColor4f colorScale;
    
        XrColor4f colorBias;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrLoaderInitInfoBaseHeaderKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerEquirect2KHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags layerFlags;
    
        XrSpace space;
    
        XrEyeVisibility eyeVisibility;
    
        XrSwapchainSubImage subImage;
    
        XrPosef pose;
    
        float radius;
    
        float centralHorizontalAngle;
    
        float upperVerticalAngle;
    
        float lowerVerticalAngle;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBindingModificationBaseHeaderKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBindingModificationsKHR
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint bindingModificationCount;
    
        IntPtr bindingModifications;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataPerfSettingsEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPerfSettingsDomainEXT domain;
    
        XrPerfSettingsSubDomainEXT subDomain;
    
        XrPerfSettingsNotificationLevelEXT fromLevel;
    
        XrPerfSettingsNotificationLevelEXT toLevel;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDebugUtilsObjectNameInfoEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrObjectType objectType;
    
        ulong objectHandle;
    
        IntPtr objectName;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDebugUtilsLabelEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        IntPtr labelName;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDebugUtilsMessengerCallbackDataEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        IntPtr messageId;
    
        IntPtr functionName;
    
        IntPtr message;
    
        uint objectCount;
    
        IntPtr objects;
    
        uint sessionLabelCount;
    
        IntPtr sessionLabels;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDebugUtilsMessengerCreateInfoEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrDebugUtilsMessageSeverityFlagsEXT messageSeverities;
    
        XrDebugUtilsMessageTypeFlagsEXT messageTypes;
    
        PFN_xrDebugUtilsMessengerCallbackEXT userCallback;
    
        IntPtr userData;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemEyeGazeInteractionPropertiesEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsEyeGazeInteraction;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEyeGazeSampleTimeEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrTime time;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSessionCreateInfoOverlayEXTX
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrOverlaySessionCreateFlagsEXTX createFlags;
    
        uint sessionLayersPlacement;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataMainSessionVisibilityChangedEXTX
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint visible;
    
        XrOverlayMainSessionFlagsEXTX flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpace space;
    
        XrPosef pose;
    
        XrTime time;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorSpaceCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpatialAnchorMSFT anchor;
    
        XrPosef poseInAnchorSpace;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerImageLayoutFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerImageLayoutFlagsFB flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerAlphaBlendFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrBlendFactorFB srcFactorColor;
    
        XrBlendFactorFB dstFactorColor;
    
        XrBlendFactorFB srcFactorAlpha;
    
        XrBlendFactorFB dstFactorAlpha;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewConfigurationDepthRangeEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float recommendedNearZ;
    
        float minNearZ;
    
        float recommendedFarZ;
    
        float maxFarZ;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialGraphNodeSpaceCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpatialGraphNodeTypeMSFT nodeType;
    
        uint8_t[] nodeId = new uint8_t[XR_GUID_SIZE_MSF];
    
        XrPosef pose;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialGraphStaticNodeBindingCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpace space;
    
        XrPosef poseInSpace;
    
        XrTime time;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialGraphNodeBindingPropertiesGetInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialGraphNodeBindingPropertiesMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint8_t[] nodeId = new uint8_t[XR_GUID_SIZE_MSF];
    
        XrPosef poseInNodeSpace;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemHandTrackingPropertiesEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsHandTracking;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackerCreateInfoEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrHandEXT hand;
    
        XrHandJointSetEXT handJointSet;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointsLocateInfoEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpace baseSpace;
    
        XrTime time;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointLocationEXT
    {
    
        XrSpaceLocationFlags locationFlags;
    
        XrPosef pose;
    
        float radius;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointVelocityEXT
    {
    
        XrSpaceVelocityFlags velocityFlags;
    
        XrVector3f linearVelocity;
    
        XrVector3f angularVelocity;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointLocationsEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint isActive;
    
        uint jointCount;
    
        IntPtr jointLocations;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointVelocitiesEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint jointCount;
    
        IntPtr jointVelocities;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemHandTrackingMeshPropertiesMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsHandTrackingMesh;
    
        uint maxHandMeshIndexCount;
    
        uint maxHandMeshVertexCount;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshSpaceCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrHandPoseTypeMSFT handPoseType;
    
        XrPosef poseInHandMeshSpace;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshUpdateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrTime time;
    
        XrHandPoseTypeMSFT handPoseType;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshIndexBufferMSFT
    {
    
        uint indexBufferKey;
    
        uint indexCapacityInput;
    
        uint indexCountOutput;
    
        IntPtr indices;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshVertexMSFT
    {
    
        XrVector3f position;
    
        XrVector3f normal;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshVertexBufferMSFT
    {
    
        XrTime vertexUpdateTime;
    
        uint vertexCapacityInput;
    
        uint vertexCountOutput;
    
        IntPtr vertices;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint isActive;
    
        uint indexBufferChanged;
    
        uint vertexBufferChanged;
    
        XrHandMeshIndexBufferMSFT indexBuffer;
    
        XrHandMeshVertexBufferMSFT vertexBuffer;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandPoseTypeInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrHandPoseTypeMSFT handPoseType;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationSessionBeginInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint viewConfigurationCount;
    
        IntPtr enabledViewConfigurationTypes;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationStateMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrViewConfigurationType viewConfigurationType;
    
        uint active;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationFrameStateMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint viewConfigurationCount;
    
        IntPtr viewConfigurationStates;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationLayerInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrViewConfigurationType viewConfigurationType;
    
        XrEnvironmentBlendMode environmentBlendMode;
    
        uint layerCount;
    
        IntPtr layers;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationFrameEndInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint viewConfigurationCount;
    
        IntPtr viewConfigurationLayersInfo;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationSwapchainCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrViewConfigurationType viewConfigurationType;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelKeyStateMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrControllerModelKeyMSFT modelKey;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelNodePropertiesMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        char[] parentNodeName = new char[XR_MAX_CONTROLLER_MODEL_NODE_NAME_SIZE_MSF];
    
        char[] nodeName = new char[XR_MAX_CONTROLLER_MODEL_NODE_NAME_SIZE_MSF];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelPropertiesMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint nodeCapacityInput;
    
        uint nodeCountOutput;
    
        IntPtr nodeProperties;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelNodeStateMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPosef nodePose;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelStateMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint nodeCapacityInput;
    
        uint nodeCountOutput;
    
        IntPtr nodeStates;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewConfigurationViewFovEPIC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrFovf recommendedFov;
    
        XrFovf maxMutableFov;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerReprojectionInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrReprojectionModeMSFT reprojectionMode;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerReprojectionPlaneOverrideMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrVector3f position;
    
        XrVector3f normal;
    
        XrVector3f velocity;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainStateBaseHeaderFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerSecureContentFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerSecureContentFlagsFB flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInteractionProfileDpadBindingEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPath binding;
    
        XrActionSet actionSet;
    
        float forceThreshold;
    
        float forceThresholdReleased;
    
        float centerRegion;
    
        float wedgeAngle;
    
        uint isSticky;
    
        IntPtr onHaptic;
    
        IntPtr offHaptic;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInteractionProfileAnalogThresholdVALVE
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAction action;
    
        XrPath binding;
    
        float onThreshold;
    
        float offThreshold;
    
        IntPtr onHaptic;
    
        IntPtr offHaptic;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointsMotionRangeInfoEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrHandJointsMotionRangeEXT handJointsMotionRange;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrUuidMSFT
    {
    
        uint8_t[] bytes = new uint8_t[1];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneObserverCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneSphereBoundMSFT
    {
    
        XrVector3f center;
    
        float radius;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneOrientedBoxBoundMSFT
    {
    
        XrPosef pose;
    
        XrVector3f extents;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneFrustumBoundMSFT
    {
    
        XrPosef pose;
    
        XrFovf fov;
    
        float farDistance;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneBoundsMSFT
    {
    
        XrSpace space;
    
        XrTime time;
    
        uint sphereCount;
    
        IntPtr spheres;
    
        uint boxCount;
    
        IntPtr boxes;
    
        uint frustumCount;
    
        IntPtr frustums;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrNewSceneComputeInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint requestedFeatureCount;
    
        IntPtr requestedFeatures;
    
        XrSceneComputeConsistencyMSFT consistency;
    
        XrSceneBoundsMSFT bounds;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVisualMeshComputeLodInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrMeshComputeLodMSFT lod;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentMSFT
    {
    
        XrSceneComponentTypeMSFT componentType;
    
        XrUuidMSFT id;
    
        XrUuidMSFT parentId;
    
        XrTime updateTime;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentsMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint componentCapacityInput;
    
        uint componentCountOutput;
    
        IntPtr components;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentsGetInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSceneComponentTypeMSFT componentType;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentLocationMSFT
    {
    
        XrSpaceLocationFlags flags;
    
        XrPosef pose;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentLocationsMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint locationCount;
    
        IntPtr locations;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentsLocateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpace baseSpace;
    
        XrTime time;
    
        uint componentIdCount;
    
        IntPtr componentIds;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneObjectMSFT
    {
    
        XrSceneObjectTypeMSFT objectType;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneObjectsMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint sceneObjectCount;
    
        IntPtr sceneObjects;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentParentFilterInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrUuidMSFT parentId;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneObjectTypesFilterInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint objectTypeCount;
    
        IntPtr objectTypes;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrScenePlaneMSFT
    {
    
        XrScenePlaneAlignmentTypeMSFT alignment;
    
        XrExtent2Df size;
    
        ulong meshBufferId;
    
        uint supportsIndicesUint16;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrScenePlanesMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint scenePlaneCount;
    
        IntPtr scenePlanes;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrScenePlaneAlignmentFilterInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint alignmentCount;
    
        IntPtr alignments;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshMSFT
    {
    
        ulong meshBufferId;
    
        uint supportsIndicesUint16;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshesMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint sceneMeshCount;
    
        IntPtr sceneMeshes;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshBuffersGetInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        ulong meshBufferId;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshBuffersMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshVertexBufferMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint vertexCapacityInput;
    
        uint vertexCountOutput;
    
        IntPtr vertices;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshIndicesUint32MSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint indexCapacityInput;
    
        uint indexCountOutput;
    
        IntPtr indices;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshIndicesUint16MSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint indexCapacityInput;
    
        uint indexCountOutput;
    
        IntPtr indices;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSerializedSceneFragmentDataGetInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrUuidMSFT sceneFragmentId;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDeserializeSceneFragmentMSFT
    {
    
        uint bufferSize;
    
        IntPtr buffer;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneDeserializeInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint fragmentCount;
    
        IntPtr fragments;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataDisplayRefreshRateChangedFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float fromDisplayRefreshRate;
    
        float toDisplayRefreshRate;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViveTrackerPathsHTCX
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPath persistentPath;
    
        XrPath rolePath;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataViveTrackerConnectedHTCX
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        IntPtr paths;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemFacialTrackingPropertiesHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportEyeFacialTracking;
    
        uint supportLipFacialTracking;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFacialExpressionsHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint isActive;
    
        XrTime sampleTime;
    
        uint expressionCount;
    
        IntPtr expressionWeightings;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFacialTrackerCreateInfoHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrFacialTrackingTypeHTC facialTrackingType;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemColorSpacePropertiesFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrColorSpaceFB colorSpace;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVector4sFB
    {
    
        int16_t x;
    
        int16_t y;
    
        int16_t z;
    
        int16_t w;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackingMeshFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint jointCapacityInput;
    
        uint jointCountOutput;
    
        IntPtr jointBindPoses;
    
        IntPtr jointRadii;
    
        IntPtr jointParents;
    
        uint vertexCapacityInput;
    
        uint vertexCountOutput;
    
        IntPtr vertexPositions;
    
        IntPtr vertexNormals;
    
        IntPtr vertexUVs;
    
        IntPtr vertexBlendIndices;
    
        IntPtr vertexBlendWeights;
    
        uint indexCapacityInput;
    
        uint indexCountOutput;
    
        IntPtr indices;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackingScaleFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float sensorOutput;
    
        float currentOutput;
    
        uint overrideHandScale;
    
        float overrideValueInput;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackingAimStateFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrHandTrackingAimFlagsFB status;
    
        XrPosef aimPose;
    
        float pinchStrengthIndex;
    
        float pinchStrengthMiddle;
    
        float pinchStrengthRing;
    
        float pinchStrengthLittle;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandCapsuleFB
    {
    
        XrVector3f[] points = new XrVector3f[XR_HAND_TRACKING_CAPSULE_POINT_COUNT_F];
    
        float radius;
    
        XrHandJointEXT joint;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackingCapsulesStateFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrHandCapsuleFB[] capsules = new XrHandCapsuleFB[XR_HAND_TRACKING_CAPSULE_COUNT_F];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemSpatialEntityPropertiesFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsSpatialEntity;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorCreateInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpace space;
    
        XrPosef poseInSpace;
    
        XrTime time;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceComponentStatusSetInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpaceComponentTypeFB componentType;
    
        uint enabled;
    
        XrDuration timeout;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceComponentStatusFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint enabled;
    
        uint changePending;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrUuidEXT
    {
    
        uint8_t[] data = new uint8_t[XR_UUID_SIZE_EX];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpatialAnchorCreateCompleteFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAsyncRequestIdFB requestId;
    
        XrResult result;
    
        XrSpace space;
    
        XrUuidEXT uuid;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceSetStatusCompleteFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAsyncRequestIdFB requestId;
    
        XrResult result;
    
        XrSpace space;
    
        XrUuidEXT uuid;
    
        XrSpaceComponentTypeFB componentType;
    
        uint enabled;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationProfileCreateInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainCreateInfoFoveationFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSwapchainCreateFoveationFlagsFB flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainStateFoveationFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSwapchainStateFoveationFlagsFB flags;
    
        XrFoveationProfileFB profile;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationLevelProfileCreateInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrFoveationLevelFB level;
    
        float verticalOffset;
    
        XrFoveationDynamicFB dynamic;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemKeyboardTrackingPropertiesFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsKeyboardTracking;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrKeyboardTrackingDescriptionFB
    {
    
        ulong trackedKeyboardId;
    
        XrVector3f size;
    
        XrKeyboardTrackingFlagsFB flags;
    
        char[] name = new char[XR_MAX_KEYBOARD_TRACKING_NAME_SIZE_F];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrKeyboardSpaceCreateInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        ulong trackedKeyboardId;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrKeyboardTrackingQueryFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrKeyboardTrackingQueryFlagsFB flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrTriangleMeshCreateInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrTriangleMeshFlagsFB flags;
    
        XrWindingOrderFB windingOrder;
    
        uint vertexCount;
    
        IntPtr vertexBuffer;
    
        uint triangleCount;
    
        IntPtr indexBuffer;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemPassthroughPropertiesFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsPassthrough;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemPassthroughProperties2FB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPassthroughCapabilityFlagsFB capabilities;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughCreateInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPassthroughFlagsFB flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughLayerCreateInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPassthroughFB passthrough;
    
        XrPassthroughFlagsFB flags;
    
        XrPassthroughLayerPurposeFB purpose;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerPassthroughFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags flags;
    
        XrSpace space;
    
        XrPassthroughLayerFB layerHandle;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrGeometryInstanceCreateInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPassthroughLayerFB layer;
    
        XrTriangleMeshFB mesh;
    
        XrSpace baseSpace;
    
        XrPosef pose;
    
        XrVector3f scale;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrGeometryInstanceTransformFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpace baseSpace;
    
        XrTime time;
    
        XrPosef pose;
    
        XrVector3f scale;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughStyleFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float textureOpacityFactor;
    
        XrColor4f edgeColor;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughColorMapMonoToRgbaFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrColor4f[] textureColorMap = new XrColor4f[XR_PASSTHROUGH_COLOR_MAP_MONO_SIZE_F];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughColorMapMonoToMonoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint8_t[] textureColorMap = new uint8_t[XR_PASSTHROUGH_COLOR_MAP_MONO_SIZE_F];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughBrightnessContrastSaturationFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float brightness;
    
        float contrast;
    
        float saturation;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataPassthroughStateChangedFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPassthroughStateChangedFlagsFB flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelPathInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPath path;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelPropertiesFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint vendorId;
    
        char[] modelName = new char[XR_MAX_RENDER_MODEL_NAME_SIZE_F];
    
        XrRenderModelKeyFB modelKey;
    
        uint modelVersion;
    
        XrRenderModelFlagsFB flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelBufferFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint bufferCapacityInput;
    
        uint bufferCountOutput;
    
        IntPtr buffer;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelLoadInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrRenderModelKeyFB modelKey;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemRenderModelPropertiesFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsRenderModelLoading;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelCapabilitiesRequestFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrRenderModelFlagsFB flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewLocateFoveatedRenderingVARJO
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint foveatedRenderingActive;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveatedViewConfigurationViewVARJO
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint foveatedRenderingActive;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemFoveatedRenderingPropertiesVARJO
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsFoveatedRendering;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerDepthTestVARJO
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float depthTestRangeNearZ;
    
        float depthTestRangeFarZ;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemMarkerTrackingPropertiesVARJO
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint supportsMarkerTracking;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataMarkerTrackingUpdateVARJO
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        ulong markerId;
    
        uint isActive;
    
        uint isPredicted;
    
        XrTime time;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrMarkerSpaceCreateInfoVARJO
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        ulong markerId;
    
        XrPosef poseInMarkerSpace;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorPersistenceNameMSFT
    {
    
        char[] name = new char[XR_MAX_SPATIAL_ANCHOR_NAME_SIZE_MSF];
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorPersistenceInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName;
    
        XrSpatialAnchorMSFT spatialAnchor;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore;
    
        XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceQueryInfoBaseHeaderFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceFilterInfoBaseHeaderFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceQueryInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpaceQueryActionFB queryAction;
    
        uint maxResultCount;
    
        XrDuration timeout;
    
        IntPtr filter;
    
        IntPtr excludeFilter;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceStorageLocationFilterInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpaceStorageLocationFB location;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceUuidFilterInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint uuidCount;
    
        IntPtr uuids;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceComponentFilterInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpaceComponentTypeFB componentType;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceQueryResultFB
    {
    
        XrSpace space;
    
        XrUuidEXT uuid;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceQueryResultsFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint resultCapacityInput;
    
        uint resultCountOutput;
    
        IntPtr results;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceQueryResultsAvailableFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAsyncRequestIdFB requestId;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceQueryCompleteFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAsyncRequestIdFB requestId;
    
        XrResult result;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceSaveInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpace space;
    
        XrSpaceStorageLocationFB location;
    
        XrSpacePersistenceModeFB persistenceMode;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceEraseInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrSpace space;
    
        XrSpaceStorageLocationFB location;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceSaveCompleteFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAsyncRequestIdFB requestId;
    
        XrResult result;
    
        XrSpace space;
    
        XrUuidEXT uuid;
    
        XrSpaceStorageLocationFB location;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceEraseCompleteFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrAsyncRequestIdFB requestId;
    
        XrResult result;
    
        XrSpace space;
    
        XrUuidEXT uuid;
    
        XrSpaceStorageLocationFB location;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerSpaceWarpInfoFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerSpaceWarpInfoFlagsFB layerFlags;
    
        XrSwapchainSubImage motionVectorSubImage;
    
        XrPosef appSpaceDeltaPose;
    
        XrSwapchainSubImage depthSubImage;
    
        float minDepth;
    
        float maxDepth;
    
        float nearZ;
    
        float farZ;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemSpaceWarpPropertiesFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint recommendedMotionVectorImageRectWidth;
    
        uint recommendedMotionVectorImageRectHeight;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrExtent3DfFB
    {
    
        float width;
    
        float height;
    
        float depth;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrOffset3DfFB
    {
    
        float x;
    
        float y;
    
        float z;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRect3DfFB
    {
    
        XrOffset3DfFB offset;
    
        XrExtent3DfFB extent;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSemanticLabelsFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint bufferCapacityInput;
    
        uint bufferCountOutput;
    
        IntPtr buffer;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRoomLayoutFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrUuidEXT floorUuid;
    
        XrUuidEXT ceilingUuid;
    
        uint wallUuidCapacityInput;
    
        uint wallUuidCountOutput;
    
        IntPtr wallUuids;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBoundary2DFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint vertexCapacityInput;
    
        uint vertexCountOutput;
    
        IntPtr vertices;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDigitalLensControlALMALENCE
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrDigitalLensControlFlagsALMALENCE flags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceContainerFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint uuidCapacityInput;
    
        uint uuidCountOutput;
    
        IntPtr uuids;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughKeyboardHandsIntensityFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float leftHandIntensity;
    
        float rightHandIntensity;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerSettingsFB
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerSettingsFlagsFB layerFlags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPerformanceMetricsStateMETA
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint enabled;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPerformanceMetricsCounterMETA
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPerformanceMetricsCounterFlagsMETA counterFlags;
    
        XrPerformanceMetricsCounterUnitMETA counterUnit;
    
        uint uintValue;
    
        float floatValue;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemHeadsetIdPropertiesMETA
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrUuidEXT id;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughCreateInfoHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrPassthroughFormHTC form;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughColorHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        float alpha;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughMeshTransformInfoHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint vertexCount;
    
        IntPtr vertices;
    
        uint indexCount;
    
        IntPtr indices;
    
        XrSpace baseSpace;
    
        XrTime time;
    
        XrPosef pose;
    
        XrVector3f scale;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerPassthroughHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrCompositionLayerFlags layerFlags;
    
        XrSpace space;
    
        XrPassthroughHTC passthrough;
    
        XrPassthroughColorHTC color;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationApplyInfoHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrFoveationModeHTC mode;
    
        uint subImageCount;
    
        IntPtr subImages;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationConfigurationHTC
    {
    
        XrFoveationLevelHTC level;
    
        float clearFovDegree;
    
        XrVector2f focalCenterOffset;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationDynamicModeInfoHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        XrFoveationDynamicFlagsHTC dynamicFlags;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationCustomModeInfoHTC
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint configCount;
    
        IntPtr configs;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActiveActionSetPriorityEXT
    {
    
        XrActionSet actionSet;
    
        uint priorityOverride;
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActiveActionSetPrioritiesEXT
    {
    
        XrStructureType type;
    
        IntPtr next;
    
        uint actionSetPriorityCount;
    
        IntPtr actionSetPriorities;
    
    }
    
}