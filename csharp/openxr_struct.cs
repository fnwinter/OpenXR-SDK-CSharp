// This file is auto-generated

namespace fn.OpenXR.Common
{
    [StructLayout(LayoutKind.Sequential)]
    struct XrApiLayerProperties
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        char layerName[XR_MAX_API_LAYER_NAME_SIZE],
    
        XrVersion specVersion,
    
        uint32_t layerVersion,
    
        char description[XR_MAX_API_LAYER_DESCRIPTION_SIZE]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrExtensionProperties
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        char extensionName[XR_MAX_EXTENSION_NAME_SIZE],
    
        uint32_t extensionVersion
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrApplicationInfo
    {
    
        char applicationName[XR_MAX_APPLICATION_NAME_SIZE],
    
        uint32_t applicationVersion,
    
        char engineName[XR_MAX_ENGINE_NAME_SIZE],
    
        uint32_t engineVersion,
    
        XrVersion apiVersion
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInstanceCreateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrInstanceCreateFlags createFlags,
    
        XrApplicationInfo applicationInfo,
    
        uint32_t enabledApiLayerCount,
    
        const char* const* enabledApiLayerNames,
    
        uint32_t enabledExtensionCount,
    
        const char* const* enabledExtensionNames
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInstanceProperties
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrVersion runtimeVersion,
    
        char runtimeName[XR_MAX_RUNTIME_NAME_SIZE]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataBuffer
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint8_t varying[4000]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemGetInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrFormFactor formFactor
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemGraphicsProperties
    {
    
        uint32_t maxSwapchainImageHeight,
    
        uint32_t maxSwapchainImageWidth,
    
        uint32_t maxLayerCount
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemTrackingProperties
    {
    
        XrBool32 orientationTracking,
    
        XrBool32 positionTracking
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemProperties
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrSystemId systemId,
    
        uint32_t vendorId,
    
        char systemName[XR_MAX_SYSTEM_NAME_SIZE],
    
        XrSystemGraphicsProperties graphicsProperties,
    
        XrSystemTrackingProperties trackingProperties
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSessionCreateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSessionCreateFlags createFlags,
    
        XrSystemId systemId
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVector3f
    {
    
        float x,
    
        float y,
    
        float z
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceVelocity
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrSpaceVelocityFlags velocityFlags,
    
        XrVector3f linearVelocity,
    
        XrVector3f angularVelocity
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrQuaternionf
    {
    
        float x,
    
        float y,
    
        float z,
    
        float w
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPosef
    {
    
        XrQuaternionf orientation,
    
        XrVector3f position
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrReferenceSpaceCreateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrReferenceSpaceType referenceSpaceType,
    
        XrPosef poseInReferenceSpace
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrExtent2Df
    {
    
        float width,
    
        float height
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionSpaceCreateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAction action,
    
        XrPath subactionPath,
    
        XrPosef poseInActionSpace
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceLocation
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrSpaceLocationFlags locationFlags,
    
        XrPosef pose
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewConfigurationProperties
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrViewConfigurationType viewConfigurationType,
    
        XrBool32 fovMutable
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewConfigurationView
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t recommendedImageRectWidth,
    
        uint32_t maxImageRectWidth,
    
        uint32_t recommendedImageRectHeight,
    
        uint32_t maxImageRectHeight,
    
        uint32_t recommendedSwapchainSampleCount,
    
        uint32_t maxSwapchainSampleCount
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainCreateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSwapchainCreateFlags createFlags,
    
        XrSwapchainUsageFlags usageFlags,
    
        int64_t format,
    
        uint32_t sampleCount,
    
        uint32_t width,
    
        uint32_t height,
    
        uint32_t faceCount,
    
        uint32_t arraySize,
    
        uint32_t mipCount
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainImageBaseHeader
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainImageAcquireInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainImageWaitInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrDuration timeout
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainImageReleaseInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSessionBeginInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrViewConfigurationType primaryViewConfigurationType
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFrameWaitInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFrameState
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrTime predictedDisplayTime,
    
        XrDuration predictedDisplayPeriod,
    
        XrBool32 shouldRender
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFrameBeginInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerBaseHeader
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags layerFlags,
    
        XrSpace space
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFrameEndInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrTime displayTime,
    
        XrEnvironmentBlendMode environmentBlendMode,
    
        uint32_t layerCount,
    
        const XrCompositionLayerBaseHeader* const* layers
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewLocateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrViewConfigurationType viewConfigurationType,
    
        XrTime displayTime,
    
        XrSpace space
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewState
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrViewStateFlags viewStateFlags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFovf
    {
    
        float angleLeft,
    
        float angleRight,
    
        float angleUp,
    
        float angleDown
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrView
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrPosef pose,
    
        XrFovf fov
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionSetCreateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        char actionSetName[XR_MAX_ACTION_SET_NAME_SIZE],
    
        char localizedActionSetName[XR_MAX_LOCALIZED_ACTION_SET_NAME_SIZE],
    
        uint32_t priority
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionCreateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        char actionName[XR_MAX_ACTION_NAME_SIZE],
    
        XrActionType actionType,
    
        uint32_t countSubactionPaths,
    
        const XrPath* subactionPaths,
    
        char localizedActionName[XR_MAX_LOCALIZED_ACTION_NAME_SIZE]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionSuggestedBinding
    {
    
        XrAction action,
    
        XrPath binding
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInteractionProfileSuggestedBinding
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPath interactionProfile,
    
        uint32_t countSuggestedBindings,
    
        const XrActionSuggestedBinding* suggestedBindings
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSessionActionSetsAttachInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t countActionSets,
    
        const XrActionSet* actionSets
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInteractionProfileState
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrPath interactionProfile
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStateGetInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAction action,
    
        XrPath subactionPath
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStateBoolean
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 currentState,
    
        XrBool32 changedSinceLastSync,
    
        XrTime lastChangeTime,
    
        XrBool32 isActive
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStateFloat
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        float currentState,
    
        XrBool32 changedSinceLastSync,
    
        XrTime lastChangeTime,
    
        XrBool32 isActive
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVector2f
    {
    
        float x,
    
        float y
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStateVector2f
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrVector2f currentState,
    
        XrBool32 changedSinceLastSync,
    
        XrTime lastChangeTime,
    
        XrBool32 isActive
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionStatePose
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 isActive
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActiveActionSet
    {
    
        XrActionSet actionSet,
    
        XrPath subactionPath
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActionsSyncInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t countActiveActionSets,
    
        const XrActiveActionSet* activeActionSets
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBoundSourcesForActionEnumerateInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAction action
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInputSourceLocalizedNameGetInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPath sourcePath,
    
        XrInputSourceLocalizedNameFlags whichComponents
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHapticActionInfo
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAction action,
    
        XrPath subactionPath
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHapticBaseHeader
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBaseInStructure
    {
    
        XrStructureType type,
    
        const struct XrBaseInStructure* next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBaseOutStructure
    {
    
        XrStructureType type,
    
        struct XrBaseOutStructure* next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrOffset2Di
    {
    
        int32_t x,
    
        int32_t y
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrExtent2Di
    {
    
        int32_t width,
    
        int32_t height
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRect2Di
    {
    
        XrOffset2Di offset,
    
        XrExtent2Di extent
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainSubImage
    {
    
        XrSwapchain swapchain,
    
        XrRect2Di imageRect,
    
        uint32_t imageArrayIndex
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerProjectionView
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPosef pose,
    
        XrFovf fov,
    
        XrSwapchainSubImage subImage
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerProjection
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags layerFlags,
    
        XrSpace space,
    
        uint32_t viewCount,
    
        const XrCompositionLayerProjectionView* views
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerQuad
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags layerFlags,
    
        XrSpace space,
    
        XrEyeVisibility eyeVisibility,
    
        XrSwapchainSubImage subImage,
    
        XrPosef pose,
    
        XrExtent2Df size
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataBaseHeader
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataEventsLost
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t lostEventCount
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataInstanceLossPending
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrTime lossTime
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSessionStateChanged
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSession session,
    
        XrSessionState state,
    
        XrTime time
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataReferenceSpaceChangePending
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSession session,
    
        XrReferenceSpaceType referenceSpaceType,
    
        XrTime changeTime,
    
        XrBool32 poseValid,
    
        XrPosef poseInPreviousSpace
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataInteractionProfileChanged
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSession session
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHapticVibration
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrDuration duration,
    
        float frequency,
    
        float amplitude
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrOffset2Df
    {
    
        float x,
    
        float y
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRect2Df
    {
    
        XrOffset2Df offset,
    
        XrExtent2Df extent
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVector4f
    {
    
        float x,
    
        float y,
    
        float z,
    
        float w
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrColor4f
    {
    
        float r,
    
        float g,
    
        float b,
    
        float a
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerCubeKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags layerFlags,
    
        XrSpace space,
    
        XrEyeVisibility eyeVisibility,
    
        XrSwapchain swapchain,
    
        uint32_t imageArrayIndex,
    
        XrQuaternionf orientation
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerDepthInfoKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSwapchainSubImage subImage,
    
        float minDepth,
    
        float maxDepth,
    
        float nearZ,
    
        float farZ
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerCylinderKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags layerFlags,
    
        XrSpace space,
    
        XrEyeVisibility eyeVisibility,
    
        XrSwapchainSubImage subImage,
    
        XrPosef pose,
    
        float radius,
    
        float centralAngle,
    
        float aspectRatio
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerEquirectKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags layerFlags,
    
        XrSpace space,
    
        XrEyeVisibility eyeVisibility,
    
        XrSwapchainSubImage subImage,
    
        XrPosef pose,
    
        float radius,
    
        XrVector2f scale,
    
        XrVector2f bias
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVisibilityMaskKHR
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t vertexCapacityInput,
    
        uint32_t vertexCountOutput,
    
        XrVector2f* vertices,
    
        uint32_t indexCapacityInput,
    
        uint32_t indexCountOutput,
    
        uint32_t* indices
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataVisibilityMaskChangedKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSession session,
    
        XrViewConfigurationType viewConfigurationType,
    
        uint32_t viewIndex
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerColorScaleBiasKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrColor4f colorScale,
    
        XrColor4f colorBias
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrLoaderInitInfoBaseHeaderKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerEquirect2KHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags layerFlags,
    
        XrSpace space,
    
        XrEyeVisibility eyeVisibility,
    
        XrSwapchainSubImage subImage,
    
        XrPosef pose,
    
        float radius,
    
        float centralHorizontalAngle,
    
        float upperVerticalAngle,
    
        float lowerVerticalAngle
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBindingModificationBaseHeaderKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBindingModificationsKHR
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t bindingModificationCount,
    
        const XrBindingModificationBaseHeaderKHR* const* bindingModifications
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataPerfSettingsEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPerfSettingsDomainEXT domain,
    
        XrPerfSettingsSubDomainEXT subDomain,
    
        XrPerfSettingsNotificationLevelEXT fromLevel,
    
        XrPerfSettingsNotificationLevelEXT toLevel
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDebugUtilsObjectNameInfoEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrObjectType objectType,
    
        uint64_t objectHandle,
    
        const char* objectName
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDebugUtilsLabelEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        const char* labelName
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDebugUtilsMessengerCallbackDataEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        const char* messageId,
    
        const char* functionName,
    
        const char* message,
    
        uint32_t objectCount,
    
        XrDebugUtilsObjectNameInfoEXT* objects,
    
        uint32_t sessionLabelCount,
    
        XrDebugUtilsLabelEXT* sessionLabels
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDebugUtilsMessengerCreateInfoEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrDebugUtilsMessageSeverityFlagsEXT messageSeverities,
    
        XrDebugUtilsMessageTypeFlagsEXT messageTypes,
    
        PFN_xrDebugUtilsMessengerCallbackEXT userCallback,
    
        void* XR_MAY_ALIAS userData
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemEyeGazeInteractionPropertiesEXT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 supportsEyeGazeInteraction
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEyeGazeSampleTimeEXT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrTime time
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSessionCreateInfoOverlayEXTX
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrOverlaySessionCreateFlagsEXTX createFlags,
    
        uint32_t sessionLayersPlacement
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataMainSessionVisibilityChangedEXTX
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrBool32 visible,
    
        XrOverlayMainSessionFlagsEXTX flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpace space,
    
        XrPosef pose,
    
        XrTime time
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorSpaceCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpatialAnchorMSFT anchor,
    
        XrPosef poseInAnchorSpace
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerImageLayoutFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrCompositionLayerImageLayoutFlagsFB flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerAlphaBlendFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBlendFactorFB srcFactorColor,
    
        XrBlendFactorFB dstFactorColor,
    
        XrBlendFactorFB srcFactorAlpha,
    
        XrBlendFactorFB dstFactorAlpha
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewConfigurationDepthRangeEXT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        float recommendedNearZ,
    
        float minNearZ,
    
        float recommendedFarZ,
    
        float maxFarZ
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialGraphNodeSpaceCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpatialGraphNodeTypeMSFT nodeType,
    
        uint8_t nodeId[XR_GUID_SIZE_MSFT],
    
        XrPosef pose
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialGraphStaticNodeBindingCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpace space,
    
        XrPosef poseInSpace,
    
        XrTime time
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialGraphNodeBindingPropertiesGetInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialGraphNodeBindingPropertiesMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint8_t nodeId[XR_GUID_SIZE_MSFT],
    
        XrPosef poseInNodeSpace
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemHandTrackingPropertiesEXT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 supportsHandTracking
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackerCreateInfoEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrHandEXT hand,
    
        XrHandJointSetEXT handJointSet
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointsLocateInfoEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpace baseSpace,
    
        XrTime time
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointLocationEXT
    {
    
        XrSpaceLocationFlags locationFlags,
    
        XrPosef pose,
    
        float radius
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointVelocityEXT
    {
    
        XrSpaceVelocityFlags velocityFlags,
    
        XrVector3f linearVelocity,
    
        XrVector3f angularVelocity
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointLocationsEXT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 isActive,
    
        uint32_t jointCount,
    
        XrHandJointLocationEXT* jointLocations
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointVelocitiesEXT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t jointCount,
    
        XrHandJointVelocityEXT* jointVelocities
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemHandTrackingMeshPropertiesMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 supportsHandTrackingMesh,
    
        uint32_t maxHandMeshIndexCount,
    
        uint32_t maxHandMeshVertexCount
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshSpaceCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrHandPoseTypeMSFT handPoseType,
    
        XrPosef poseInHandMeshSpace
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshUpdateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrTime time,
    
        XrHandPoseTypeMSFT handPoseType
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshIndexBufferMSFT
    {
    
        uint32_t indexBufferKey,
    
        uint32_t indexCapacityInput,
    
        uint32_t indexCountOutput,
    
        uint32_t* indices
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshVertexMSFT
    {
    
        XrVector3f position,
    
        XrVector3f normal
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshVertexBufferMSFT
    {
    
        XrTime vertexUpdateTime,
    
        uint32_t vertexCapacityInput,
    
        uint32_t vertexCountOutput,
    
        XrHandMeshVertexMSFT* vertices
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandMeshMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 isActive,
    
        XrBool32 indexBufferChanged,
    
        XrBool32 vertexBufferChanged,
    
        XrHandMeshIndexBufferMSFT indexBuffer,
    
        XrHandMeshVertexBufferMSFT vertexBuffer
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandPoseTypeInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrHandPoseTypeMSFT handPoseType
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationSessionBeginInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t viewConfigurationCount,
    
        const XrViewConfigurationType* enabledViewConfigurationTypes
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationStateMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrViewConfigurationType viewConfigurationType,
    
        XrBool32 active
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationFrameStateMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t viewConfigurationCount,
    
        XrSecondaryViewConfigurationStateMSFT* viewConfigurationStates
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationLayerInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrViewConfigurationType viewConfigurationType,
    
        XrEnvironmentBlendMode environmentBlendMode,
    
        uint32_t layerCount,
    
        const XrCompositionLayerBaseHeader* const* layers
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationFrameEndInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t viewConfigurationCount,
    
        const XrSecondaryViewConfigurationLayerInfoMSFT* viewConfigurationLayersInfo
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSecondaryViewConfigurationSwapchainCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrViewConfigurationType viewConfigurationType
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelKeyStateMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrControllerModelKeyMSFT modelKey
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelNodePropertiesMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        char parentNodeName[XR_MAX_CONTROLLER_MODEL_NODE_NAME_SIZE_MSFT],
    
        char nodeName[XR_MAX_CONTROLLER_MODEL_NODE_NAME_SIZE_MSFT]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelPropertiesMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t nodeCapacityInput,
    
        uint32_t nodeCountOutput,
    
        XrControllerModelNodePropertiesMSFT* nodeProperties
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelNodeStateMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrPosef nodePose
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrControllerModelStateMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t nodeCapacityInput,
    
        uint32_t nodeCountOutput,
    
        XrControllerModelNodeStateMSFT* nodeStates
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewConfigurationViewFovEPIC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrFovf recommendedFov,
    
        XrFovf maxMutableFov
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerReprojectionInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrReprojectionModeMSFT reprojectionMode
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerReprojectionPlaneOverrideMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrVector3f position,
    
        XrVector3f normal,
    
        XrVector3f velocity
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainStateBaseHeaderFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerSecureContentFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerSecureContentFlagsFB flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInteractionProfileDpadBindingEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPath binding,
    
        XrActionSet actionSet,
    
        float forceThreshold,
    
        float forceThresholdReleased,
    
        float centerRegion,
    
        float wedgeAngle,
    
        XrBool32 isSticky,
    
        const XrHapticBaseHeader* onHaptic,
    
        const XrHapticBaseHeader* offHaptic
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrInteractionProfileAnalogThresholdVALVE
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAction action,
    
        XrPath binding,
    
        float onThreshold,
    
        float offThreshold,
    
        const XrHapticBaseHeader* onHaptic,
    
        const XrHapticBaseHeader* offHaptic
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandJointsMotionRangeInfoEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrHandJointsMotionRangeEXT handJointsMotionRange
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrUuidMSFT
    {
    
        uint8_t bytes[16]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneObserverCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneSphereBoundMSFT
    {
    
        XrVector3f center,
    
        float radius
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneOrientedBoxBoundMSFT
    {
    
        XrPosef pose,
    
        XrVector3f extents
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneFrustumBoundMSFT
    {
    
        XrPosef pose,
    
        XrFovf fov,
    
        float farDistance
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneBoundsMSFT
    {
    
        XrSpace space,
    
        XrTime time,
    
        uint32_t sphereCount,
    
        const XrSceneSphereBoundMSFT* spheres,
    
        uint32_t boxCount,
    
        const XrSceneOrientedBoxBoundMSFT* boxes,
    
        uint32_t frustumCount,
    
        const XrSceneFrustumBoundMSFT* frustums
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrNewSceneComputeInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t requestedFeatureCount,
    
        const XrSceneComputeFeatureMSFT* requestedFeatures,
    
        XrSceneComputeConsistencyMSFT consistency,
    
        XrSceneBoundsMSFT bounds
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVisualMeshComputeLodInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrMeshComputeLodMSFT lod
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentMSFT
    {
    
        XrSceneComponentTypeMSFT componentType,
    
        XrUuidMSFT id,
    
        XrUuidMSFT parentId,
    
        XrTime updateTime
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentsMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t componentCapacityInput,
    
        uint32_t componentCountOutput,
    
        XrSceneComponentMSFT* components
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentsGetInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSceneComponentTypeMSFT componentType
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentLocationMSFT
    {
    
        XrSpaceLocationFlags flags,
    
        XrPosef pose
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentLocationsMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t locationCount,
    
        XrSceneComponentLocationMSFT* locations
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentsLocateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpace baseSpace,
    
        XrTime time,
    
        uint32_t componentIdCount,
    
        const XrUuidMSFT* componentIds
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneObjectMSFT
    {
    
        XrSceneObjectTypeMSFT objectType
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneObjectsMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t sceneObjectCount,
    
        XrSceneObjectMSFT* sceneObjects
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneComponentParentFilterInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrUuidMSFT parentId
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneObjectTypesFilterInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t objectTypeCount,
    
        const XrSceneObjectTypeMSFT* objectTypes
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrScenePlaneMSFT
    {
    
        XrScenePlaneAlignmentTypeMSFT alignment,
    
        XrExtent2Df size,
    
        uint64_t meshBufferId,
    
        XrBool32 supportsIndicesUint16
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrScenePlanesMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t scenePlaneCount,
    
        XrScenePlaneMSFT* scenePlanes
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrScenePlaneAlignmentFilterInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t alignmentCount,
    
        const XrScenePlaneAlignmentTypeMSFT* alignments
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshMSFT
    {
    
        uint64_t meshBufferId,
    
        XrBool32 supportsIndicesUint16
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshesMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t sceneMeshCount,
    
        XrSceneMeshMSFT* sceneMeshes
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshBuffersGetInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint64_t meshBufferId
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshBuffersMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshVertexBufferMSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t vertexCapacityInput,
    
        uint32_t vertexCountOutput,
    
        XrVector3f* vertices
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshIndicesUint32MSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t indexCapacityInput,
    
        uint32_t indexCountOutput,
    
        uint32_t* indices
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneMeshIndicesUint16MSFT
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t indexCapacityInput,
    
        uint32_t indexCountOutput,
    
        uint16_t* indices
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSerializedSceneFragmentDataGetInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrUuidMSFT sceneFragmentId
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDeserializeSceneFragmentMSFT
    {
    
        uint32_t bufferSize,
    
        const uint8_t* buffer
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSceneDeserializeInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t fragmentCount,
    
        const XrDeserializeSceneFragmentMSFT* fragments
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataDisplayRefreshRateChangedFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        float fromDisplayRefreshRate,
    
        float toDisplayRefreshRate
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViveTrackerPathsHTCX
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrPath persistentPath,
    
        XrPath rolePath
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataViveTrackerConnectedHTCX
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrViveTrackerPathsHTCX* paths
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemFacialTrackingPropertiesHTC
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 supportEyeFacialTracking,
    
        XrBool32 supportLipFacialTracking
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFacialExpressionsHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrBool32 isActive,
    
        XrTime sampleTime,
    
        uint32_t expressionCount,
    
        float* expressionWeightings
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFacialTrackerCreateInfoHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrFacialTrackingTypeHTC facialTrackingType
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemColorSpacePropertiesFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrColorSpaceFB colorSpace
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrVector4sFB
    {
    
        int16_t x,
    
        int16_t y,
    
        int16_t z,
    
        int16_t w
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackingMeshFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t jointCapacityInput,
    
        uint32_t jointCountOutput,
    
        XrPosef* jointBindPoses,
    
        float* jointRadii,
    
        XrHandJointEXT* jointParents,
    
        uint32_t vertexCapacityInput,
    
        uint32_t vertexCountOutput,
    
        XrVector3f* vertexPositions,
    
        XrVector3f* vertexNormals,
    
        XrVector2f* vertexUVs,
    
        XrVector4sFB* vertexBlendIndices,
    
        XrVector4f* vertexBlendWeights,
    
        uint32_t indexCapacityInput,
    
        uint32_t indexCountOutput,
    
        int16_t* indices
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackingScaleFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        float sensorOutput,
    
        float currentOutput,
    
        XrBool32 overrideHandScale,
    
        float overrideValueInput
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackingAimStateFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrHandTrackingAimFlagsFB status,
    
        XrPosef aimPose,
    
        float pinchStrengthIndex,
    
        float pinchStrengthMiddle,
    
        float pinchStrengthRing,
    
        float pinchStrengthLittle
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandCapsuleFB
    {
    
        XrVector3f points[XR_HAND_TRACKING_CAPSULE_POINT_COUNT_FB],
    
        float radius,
    
        XrHandJointEXT joint
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrHandTrackingCapsulesStateFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrHandCapsuleFB capsules[XR_HAND_TRACKING_CAPSULE_COUNT_FB]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemSpatialEntityPropertiesFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrBool32 supportsSpatialEntity
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorCreateInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpace space,
    
        XrPosef poseInSpace,
    
        XrTime time
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceComponentStatusSetInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpaceComponentTypeFB componentType,
    
        XrBool32 enabled,
    
        XrDuration timeout
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceComponentStatusFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 enabled,
    
        XrBool32 changePending
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrUuidEXT
    {
    
        uint8_t data[XR_UUID_SIZE_EXT]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpatialAnchorCreateCompleteFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAsyncRequestIdFB requestId,
    
        XrResult result,
    
        XrSpace space,
    
        XrUuidEXT uuid
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceSetStatusCompleteFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAsyncRequestIdFB requestId,
    
        XrResult result,
    
        XrSpace space,
    
        XrUuidEXT uuid,
    
        XrSpaceComponentTypeFB componentType,
    
        XrBool32 enabled
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationProfileCreateInfoFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainCreateInfoFoveationFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrSwapchainCreateFoveationFlagsFB flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSwapchainStateFoveationFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrSwapchainStateFoveationFlagsFB flags,
    
        XrFoveationProfileFB profile
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationLevelProfileCreateInfoFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrFoveationLevelFB level,
    
        float verticalOffset,
    
        XrFoveationDynamicFB dynamic
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemKeyboardTrackingPropertiesFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 supportsKeyboardTracking
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrKeyboardTrackingDescriptionFB
    {
    
        uint64_t trackedKeyboardId,
    
        XrVector3f size,
    
        XrKeyboardTrackingFlagsFB flags,
    
        char name[XR_MAX_KEYBOARD_TRACKING_NAME_SIZE_FB]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrKeyboardSpaceCreateInfoFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint64_t trackedKeyboardId
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrKeyboardTrackingQueryFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrKeyboardTrackingQueryFlagsFB flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrTriangleMeshCreateInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrTriangleMeshFlagsFB flags,
    
        XrWindingOrderFB windingOrder,
    
        uint32_t vertexCount,
    
        const XrVector3f* vertexBuffer,
    
        uint32_t triangleCount,
    
        const uint32_t* indexBuffer
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemPassthroughPropertiesFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrBool32 supportsPassthrough
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemPassthroughProperties2FB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPassthroughCapabilityFlagsFB capabilities
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughCreateInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPassthroughFlagsFB flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughLayerCreateInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPassthroughFB passthrough,
    
        XrPassthroughFlagsFB flags,
    
        XrPassthroughLayerPurposeFB purpose
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerPassthroughFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags flags,
    
        XrSpace space,
    
        XrPassthroughLayerFB layerHandle
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrGeometryInstanceCreateInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPassthroughLayerFB layer,
    
        XrTriangleMeshFB mesh,
    
        XrSpace baseSpace,
    
        XrPosef pose,
    
        XrVector3f scale
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrGeometryInstanceTransformFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpace baseSpace,
    
        XrTime time,
    
        XrPosef pose,
    
        XrVector3f scale
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughStyleFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        float textureOpacityFactor,
    
        XrColor4f edgeColor
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughColorMapMonoToRgbaFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrColor4f textureColorMap[XR_PASSTHROUGH_COLOR_MAP_MONO_SIZE_FB]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughColorMapMonoToMonoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint8_t textureColorMap[XR_PASSTHROUGH_COLOR_MAP_MONO_SIZE_FB]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughBrightnessContrastSaturationFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        float brightness,
    
        float contrast,
    
        float saturation
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataPassthroughStateChangedFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPassthroughStateChangedFlagsFB flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelPathInfoFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrPath path
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelPropertiesFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t vendorId,
    
        char modelName[XR_MAX_RENDER_MODEL_NAME_SIZE_FB],
    
        XrRenderModelKeyFB modelKey,
    
        uint32_t modelVersion,
    
        XrRenderModelFlagsFB flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelBufferFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t bufferCapacityInput,
    
        uint32_t bufferCountOutput,
    
        uint8_t* buffer
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelLoadInfoFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrRenderModelKeyFB modelKey
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemRenderModelPropertiesFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 supportsRenderModelLoading
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRenderModelCapabilitiesRequestFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrRenderModelFlagsFB flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrViewLocateFoveatedRenderingVARJO
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrBool32 foveatedRenderingActive
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveatedViewConfigurationViewVARJO
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 foveatedRenderingActive
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemFoveatedRenderingPropertiesVARJO
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 supportsFoveatedRendering
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerDepthTestVARJO
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        float depthTestRangeNearZ,
    
        float depthTestRangeFarZ
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemMarkerTrackingPropertiesVARJO
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrBool32 supportsMarkerTracking
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataMarkerTrackingUpdateVARJO
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint64_t markerId,
    
        XrBool32 isActive,
    
        XrBool32 isPredicted,
    
        XrTime time
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrMarkerSpaceCreateInfoVARJO
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint64_t markerId,
    
        XrPosef poseInMarkerSpace
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorPersistenceNameMSFT
    {
    
        char name[XR_MAX_SPATIAL_ANCHOR_NAME_SIZE_MSFT]
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorPersistenceInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName,
    
        XrSpatialAnchorMSFT spatialAnchor
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore,
    
        XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceQueryInfoBaseHeaderFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceFilterInfoBaseHeaderFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceQueryInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpaceQueryActionFB queryAction,
    
        uint32_t maxResultCount,
    
        XrDuration timeout,
    
        const XrSpaceFilterInfoBaseHeaderFB* filter,
    
        const XrSpaceFilterInfoBaseHeaderFB* excludeFilter
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceStorageLocationFilterInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpaceStorageLocationFB location
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceUuidFilterInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t uuidCount,
    
        XrUuidEXT* uuids
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceComponentFilterInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpaceComponentTypeFB componentType
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceQueryResultFB
    {
    
        XrSpace space,
    
        XrUuidEXT uuid
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceQueryResultsFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t resultCapacityInput,
    
        uint32_t resultCountOutput,
    
        XrSpaceQueryResultFB* results
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceQueryResultsAvailableFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAsyncRequestIdFB requestId
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceQueryCompleteFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAsyncRequestIdFB requestId,
    
        XrResult result
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceSaveInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpace space,
    
        XrSpaceStorageLocationFB location,
    
        XrSpacePersistenceModeFB persistenceMode
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceEraseInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrSpace space,
    
        XrSpaceStorageLocationFB location
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceSaveCompleteFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAsyncRequestIdFB requestId,
    
        XrResult result,
    
        XrSpace space,
    
        XrUuidEXT uuid,
    
        XrSpaceStorageLocationFB location
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrEventDataSpaceEraseCompleteFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrAsyncRequestIdFB requestId,
    
        XrResult result,
    
        XrSpace space,
    
        XrUuidEXT uuid,
    
        XrSpaceStorageLocationFB location
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerSpaceWarpInfoFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerSpaceWarpInfoFlagsFB layerFlags,
    
        XrSwapchainSubImage motionVectorSubImage,
    
        XrPosef appSpaceDeltaPose,
    
        XrSwapchainSubImage depthSubImage,
    
        float minDepth,
    
        float maxDepth,
    
        float nearZ,
    
        float farZ
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemSpaceWarpPropertiesFB
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        uint32_t recommendedMotionVectorImageRectWidth,
    
        uint32_t recommendedMotionVectorImageRectHeight
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrExtent3DfFB
    {
    
        float width,
    
        float height,
    
        float depth
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrOffset3DfFB
    {
    
        float x,
    
        float y,
    
        float z
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRect3DfFB
    {
    
        XrOffset3DfFB offset,
    
        XrExtent3DfFB extent
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSemanticLabelsFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t bufferCapacityInput,
    
        uint32_t bufferCountOutput,
    
        char* buffer
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrRoomLayoutFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrUuidEXT floorUuid,
    
        XrUuidEXT ceilingUuid,
    
        uint32_t wallUuidCapacityInput,
    
        uint32_t wallUuidCountOutput,
    
        XrUuidEXT* wallUuids
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrBoundary2DFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t vertexCapacityInput,
    
        uint32_t vertexCountOutput,
    
        XrVector2f* vertices
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrDigitalLensControlALMALENCE
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrDigitalLensControlFlagsALMALENCE flags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSpaceContainerFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t uuidCapacityInput,
    
        uint32_t uuidCountOutput,
    
        XrUuidEXT* uuids
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughKeyboardHandsIntensityFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        float leftHandIntensity,
    
        float rightHandIntensity
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerSettingsFB
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerSettingsFlagsFB layerFlags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPerformanceMetricsStateMETA
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrBool32 enabled
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPerformanceMetricsCounterMETA
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPerformanceMetricsCounterFlagsMETA counterFlags,
    
        XrPerformanceMetricsCounterUnitMETA counterUnit,
    
        uint32_t uintValue,
    
        float floatValue
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrSystemHeadsetIdPropertiesMETA
    {
    
        XrStructureType type,
    
        void* XR_MAY_ALIAS next,
    
        XrUuidEXT id
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughCreateInfoHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrPassthroughFormHTC form
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughColorHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        float alpha
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrPassthroughMeshTransformInfoHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t vertexCount,
    
        const XrVector3f* vertices,
    
        uint32_t indexCount,
    
        const uint32_t* indices,
    
        XrSpace baseSpace,
    
        XrTime time,
    
        XrPosef pose,
    
        XrVector3f scale
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrCompositionLayerPassthroughHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrCompositionLayerFlags layerFlags,
    
        XrSpace space,
    
        XrPassthroughHTC passthrough,
    
        XrPassthroughColorHTC color
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationApplyInfoHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrFoveationModeHTC mode,
    
        uint32_t subImageCount,
    
        XrSwapchainSubImage* subImages
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationConfigurationHTC
    {
    
        XrFoveationLevelHTC level,
    
        float clearFovDegree,
    
        XrVector2f focalCenterOffset
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationDynamicModeInfoHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        XrFoveationDynamicFlagsHTC dynamicFlags
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrFoveationCustomModeInfoHTC
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t configCount,
    
        const XrFoveationConfigurationHTC* configs
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActiveActionSetPriorityEXT
    {
    
        XrActionSet actionSet,
    
        uint32_t priorityOverride
    
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct XrActiveActionSetPrioritiesEXT
    {
    
        XrStructureType type,
    
        const void* XR_MAY_ALIAS next,
    
        uint32_t actionSetPriorityCount,
    
        const XrActiveActionSetPriorityEXT* actionSetPriorities
    
    }
    
}