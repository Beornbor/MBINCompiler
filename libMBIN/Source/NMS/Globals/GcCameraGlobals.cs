using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x4950, GUID = 0x70CC9AF14C8737E)]
    public class GcCameraGlobals : NMSTemplate
    {
        /* 0x0000 */ public GcCameraFollowSettings VehicleCamHmd;
        /* 0x00E8 */ public GcCameraFollowSettings VehicleCam;
        /* 0x01D0 */ public float SpecialVehicleMouseRecentreTime;
        /* 0x01D4 */ public float SpecialVehicleMouseRecentreWeaponTime;
        /* 0x01D8 */ public float HmdEyeLookAngle;
        /* 0x01DC */ public float HmdEyeExtraTurnAngle;
        /* 0x01E0 */ public float HmdEyeExtraTurnMinHeadAngle;
        /* 0x01E4 */ public float HmdEyeExtraTurnHeadAngleRange;
        /* 0x01E8 */ public bool PauseThirdPersonCamInPause;
        /* 0x01EC */ public float DebugPlanetJumpNearHeight;
        /* 0x01F0 */ public float DebugPlanetJumpFarHeight;
        /* 0x01F4 */ public float TogglePerspectiveBlendTime;
        /* 0x01F8 */ public float UnderwaterCameraSurfaceOffset;
        /* 0x01FC */ public float ThirdPersonAfterIntroCamBlendTime;
        /* 0x0200 */ public float ThirdPersonSkipIntroCamBlendTime;
        /* 0x0204 */ public float VehicleExitFlashTime;
        /* 0x0208 */ public float VehicleExitFlashStrength;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x020C */ public byte[] Padding20C;
        /* 0x0210 */ public Colour VehicleExitFlashColour;
        /* 0x0220 */ public float VehicleFirstToThirdExitOffsetY;
        /* 0x0224 */ public float VehicleFirstToThirdExitOffsetZ;
        /* 0x0228 */ public float ShipThirdPersonBlendTime;
        /* 0x022C */ public float ShipThirdPersonBlendWithOffsetTime;
        /* 0x0230 */ public float ShipThirdPersonBlendOffset;
        /* 0x0234 */ public float ShipThirdPersonBlendOutTime;
        /* 0x0238 */ public float ShipThirdPersonBlendOutOffset;
        /* 0x023C */ public float ShipFirstPersonBlendTime;
        /* 0x0240 */ public float ShipFirstPersonBlendOffset;
        /* 0x0244 */ public float ShipThirdPersonEnterBlendTime;
        /* 0x0248 */ public float ShipThirdPersonEnterBlendOffset;
        /* 0x024C */ public float FlybyMinRange;
        /* 0x0250 */ public float FlybyRange;
        /* 0x0254 */ public float FlybyMinRelativeSpeed;
        /* 0x0258 */ public float FlybyRelativeSpeedRange;
        /* 0x025C */ public float FlybyInVehicleDamper;
        /* 0x0260 */ public float BinocularFlashTime;
        /* 0x0264 */ public float BinocularFlashStrength;
        /* 0x0268 */ public float MinFirstPersonCameraPitch;
        /* 0x026C */ public float MaxFirstPersonCameraPitch;
        /* 0x0270 */ public float MaxCreatureRidingYaw;
        /* 0x0274 */ public float VehicleThirdPersonShootOffsetReturnTime;
        /* 0x0278 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x027C */ public byte[] Padding27C;
        /* 0x0280 */ public GcCameraFollowSettings CharacterUnarmedCam;
        /* 0x0368 */ public GcCameraFollowSettings CharacterRunCam;
        /* 0x0450 */ public GcCameraFollowSettings CharacterCombatCam;
        /* 0x0538 */ public GcCameraFollowSettings CharacterIndoorCam;
        /* 0x0620 */ public GcCameraFollowSettings CharacterNexusCam;
        /* 0x0708 */ public GcCameraFollowSettings CharacterAirborneCam;
        /* 0x07F0 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        /* 0x08D8 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        /* 0x09C0 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        /* 0x0AA8 */ public GcCameraFollowSettings CharacterFallingCam;
        /* 0x0B90 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        /* 0x0C78 */ public GcCameraFollowSettings CharacterSpaceCam;
        /* 0x0D60 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        /* 0x0E48 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        /* 0x0F30 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        /* 0x1018 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        /* 0x1100 */ public GcCameraFollowSettings CharacterGrabbedCam;
        /* 0x11E8 */ public GcCameraFollowSettings CharacterSitCam;
        /* 0x12D0 */ public GcCameraFollowSettings CharacterRideCam;
        /* 0x1320 */ public GcCameraFollowSettings CharacterRideCamMedium;
        /* 0x14A0 */ public GcCameraFollowSettings CharacterRideCamLarge;
        /* 0x1588 */ public GcCameraFollowSettings CharacterRideCamHuge;
        /* 0x1670 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1674 */ public byte[] Padding1674;
        /* 0x1678 */ public GcCameraFollowSettings BuggyFollowCam;
        /* 0x1760 */ public GcCameraFollowSettings HovercraftFollowCam;
        /* 0x1848 */ public GcCameraFollowSettings SubmarineFollowCam;
        /* 0x1930 */ public GcCameraFollowSettings BikeFollowCam;
        /* 0x1A18 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        /* 0x1B00 */ public GcCameraFollowSettings TruckFollowCam;
        /* 0x1BE8 */ public GcCameraFollowSettings MechFollowCam;
        /* 0x1CD0 */ public GcCameraFollowSettings MechShootCam;
        /* 0x1DB8 */ public GcCameraFollowSettings MechJetpackCam;
        /* 0x1EA0 */ public GcCameraFollowSettings SpaceshipFollowCam;
        /* 0x1F88 */ public GcCameraFollowSettings DropshipFollowCam;
        /* 0x2070 */ public GcCameraFollowSettings ShuttleFollowCam;
        /* 0x2158 */ public GcCameraFollowSettings RoyalShipFollowCam;
        /* 0x2240 */ public GcCameraFollowSettings ScienceShipFollowCam;
        /* 0x2328 */ public GcCameraFollowSettings AlienShipFollowCam;
        /* 0x2410 */ public float FrontendModelCameraSpringTime;
        /* 0x2414 */ public float ModelViewFlashTime;
        /* 0x2420 */ public Vector3f ModelViewOffset;
        /* 0x2430 */ public Vector2f ModelViewFocusOffset;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2438 */ public byte[] Padding2438;
        /* 0x2440 */ public Vector3f InteractionOffset;
        /* 0x2450 */ public Vector3f InteractionOffsetExtraVR;
        /* 0x2460 */ public Vector3f InteractionOffsetExtraVRSeated;
        /* 0x2470 */ public Vector3f InteractionOffsetDefault;
        /* 0x2480 */ public Vector3f InteractionOffsetGek;
        /* 0x2490 */ public Vector3f InteractionShipFocusOffset;
        /* 0x24A0 */ public Vector3f InteractionHailingFocusOffset;
        /* 0x24B0 */ public float InteractionHeadHeightDefault;
        /* 0x24B4 */ public float InteractionHeadHeightGek;
        /* 0x24B8 */ public float InteractionHeadHeightVykeen;
        /* 0x24BC */ public float InteractionPitchAdjustTime;
        /* 0x24C0 */ public float InteractionPitchAdjustStrength;
        /* 0x24C4 */ public float InteractionPitchAdjustDeadZone;
        /* 0x24C8 */ public float InteractionHeadPosHeightAdjust;
        /* 0x24CC */ public float NPCTradeLateralShiftAmount;
        /* 0x24D0 */ public float NPCTradeLateralShiftTime;
        /* 0x24D4 */ public float DistanceForFleetInteraction;
        /* 0x24D8 */ public float DistanceForFrigateInteraction;
        /* 0x24DC */ public float DistanceForFrigatePurchaseInteraction;
        /* 0x24E0 */ public Vector3f OffsetForFleetInteraction;
        /* 0x24F0 */ public Vector3f OffsetForFrigateInteraction;
        /* 0x2500 */ public float FleetUIOrbitRate;
        /* 0x2504 */ public float FleetUIVerticalMotionDuration;
        /* 0x2508 */ public float FleetUIVerticalMotionAmplitude;
        /* 0x250C */ public Vector2f PitchForFrigateInteraction;
        /* 0x2514 */ public Vector2f RotationForFrigateInteraction;
        /* 0x251C */ public float InteractionModeBlendTime;
        /* 0x2520 */ public float InteractionModeFocusCamBlend;
        /* 0x2524 */ public float InteractionModeFoV;
        /* 0x2528 */ public float MinInteractFocusAngle;
        /* 0x252C */ public float ModelViewInterpTime;
        /* 0x2530 */ public float ThirdPersonBlendInTime;
        /* 0x2534 */ public float ThirdPersonBlendOutTime;
        /* 0x2538 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        /* 0x253C */ public float ThirdPersonOffsetSpringTime;
        /* 0x2540 */ public bool MaxBob;
        /* 0x2544 */ public float PhotoModeMoveSpeed;
        /* 0x2548 */ public float PhotoModeTurnSpeed;
        /* 0x254C */ public float PhotoModeMaxDistance;
        /* 0x2550 */ public float PhotoModeMaxDistanceSpace;
        /* 0x2554 */ public float PhotoModeMaxDistanceClampForce;
        /* 0x2558 */ public float PhotoModeMaxDistanceClampBuffer;
        /* 0x255C */ public float PhotoModeCollisionRadius;
        /* 0x2560 */ public float PhotoModeRollSpeed;
        /* 0x2564 */ public float PhotoModeFlashDuration;
        /* 0x2568 */ public float PhotoModeFlashIntensity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x256C */ public byte[] Padding256C;
        /* 0x2570 */ public Vector3f PhotoModeShipOffset;
        /* 0x2580 */ public Vector3f BuildingModeInitialOffset;
        /* 0x2590 */ public float BuildingModeMaxDistance;
        /* 0x2594 */ public float RunningFoVAdjust;
        /* 0x2598 */ public float MeleeBoostedFoV;
        /* 0x259C */ public float MeleeFoV;
        /* 0x25A0 */ public float AerialViewDownDistance;
        /* 0x25A4 */ public float AerialViewPause;
        /* 0x25A8 */ public float AerialViewStartTime;
        /* 0x25AC */ public float AerialViewBackTime;
        /* 0x25B0 */ public float AerialViewBlendTime;
        /* 0x25B4 */ public TkCurveType AerialViewCurve;
        /* 0x25B8 */ public GcCameraAerialViewData BeaconTransition;
        /* 0x25E8 */ public GcCameraAerialViewData SignalTransition;
        /* 0x2618 */ public GcCameraAerialViewData WaypointTransition;
        /* 0x2648 */ public GcCameraAerialViewData RadioTowerTransition;
        /* 0x2678 */ public float ScreenshotHorizonHeight;
        /* 0x267C */ public float ScreenshotHorizonFaceFactor;
        /* 0x2680 */ public float ScreenshotBendDownAmount;
        /* 0x2684 */ public float ScreenshotRightDistance;
        /* 0x2688 */ public float ScreenshotBackDistance;
        /* 0x268C */ public float ScreenshotInTime;
        /* 0x2690 */ public float ScreenshotOutTime;
        /* 0x2694 */ public float ShipCamSpringStrengthMin;
        /* 0x2698 */ public float ShipCamSpringStrengthMax;
        /* 0x269C */ public float ShipCamTurn;
        /* 0x26A0 */ public float ShipCamPitch;
        /* 0x26A4 */ public float ShipCamPitchMod;
        /* 0x26A8 */ public float ShipCamLookInterp;
        /* 0x26AC */ public float ShipCamMinReturnTime;
        /* 0x26B0 */ public float ShipCamReturnTime;
        /* 0x26B4 */ public float ShipCamMotionTurn;
        /* 0x26B8 */ public float ShipCamMotionPitch;
        /* 0x26BC */ public float ShipCamMotionPitchMod;
        /* 0x26C0 */ public float ShipCamMotionMaxLagTurnAngle;
        /* 0x26C4 */ public float ShipCamMotionMaxLagPitchAngle;
        /* 0x26C8 */ public float ShipCamMotionInterp;
        /* 0x26CC */ public float ShipCamRollAmountMin;
        /* 0x26D0 */ public float ShipCamRollAmountMax;
        /* 0x26D4 */ public float ShipCamRollSpeedScaler;
        /* 0x26D8 */ public float ShipCamAimFOV;
        /* 0x26DC */ public float MouseSensitivity;
        /* 0x26E0 */ public float ModelViewRotateSpeed;
        /* 0x26E4 */ public float ModelViewMouseRotateSpeed;
        /* 0x26E8 */ public float ModelViewMouseRotateSnapStrength;
        /* 0x26EC */ public float ModelViewMouseMoveSpeed;
        /* 0x26F0 */ public float ModelViewDistSpeed;
        /* 0x26F4 */ public float ModelViewMinDist;
        /* 0x26F8 */ public float ModelViewMaxDist;
        /* 0x26FC */ public float ModelViewDefaultPitch;
        /* 0x2700 */ public float ModelViewDefaultYaw;
        /* 0x2704 */ public bool DebugMoveCam;
        /* 0x2708 */ public float DebugMoveCamSpeed;
        /* 0x270C */ public float DebugMoveCamHeight;
        /* 0x2710 */ public bool DebugAICam;
        /* 0x2714 */ public float DebugAICamUp;
        /* 0x2718 */ public float DebugAICamAt;
        /* 0x271C */ public float PainShakeTime;
        /* 0x2720 */ public float ShipShakeDamper;
        /* 0x2724 */ public float IndoorCamShakeDamper;
        /* 0x2728 */ public float FirstPersonSlerpAway;
        /* 0x272C */ public float FirstPersonSlerpTowards;
        [NMS(Size = 0x26)]
        /* 0x2730 */ public GcCameraShakeData[] CameraShakeTable;
        /* 0x43B0 */ public float BobAmount;
        /* 0x43B4 */ public float BobFactor;
        /* 0x43B8 */ public float BobFocus;
        /* 0x43BC */ public float BobRollFactor;
        /* 0x43C0 */ public float BobRollAmount;
        /* 0x43C4 */ public float BobRollOffset;
        /* 0x43C8 */ public float BobFwdAmount;
        /* 0x43CC */ public float CamSeed1;
        /* 0x43D0 */ public float CamSeed2;
        /* 0x43D4 */ public float CamWander1Phase;
        /* 0x43D8 */ public float CamWander2Phase;
        /* 0x43DC */ public float CamWander1Amplitude;
        /* 0x43E0 */ public float CamWander2Amplitude;
        /* 0x43E4 */ public float DebugSpaceStationTeleportOffset;
        /* 0x43E8 */ public float DebugCameraSlowFactor;
        /* 0x43EC */ public float DebugCameraFastFactor;
        /* 0x43F0 */ public float DebugCameraSpaceFastFactor;
        /* 0x43F4 */ public float OffsetCamFOV;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x43F8 */ public byte[] Padding43F8;
        /* 0x4400 */ public Vector3f OffsetCamOffset;
        /* 0x4410 */ public Vector3f OffsetCamRotation;
        /* 0x4420 */ public float ObjectFocusTime;
        /* 0x4424 */ public float CharCamFocusHeight;
        /* 0x4428 */ public float CharCamMaxDistance;
        /* 0x442C */ public float CharCamMinDistance;
        /* 0x4430 */ public float CharCamHeight;
        /* 0x4434 */ public float CharCamOffsetTime;
        /* 0x4438 */ public float CharCamAutoDirStartTime;
        /* 0x443C */ public float CharCamLookOffset;
        /* 0x4440 */ public float CharCamLookOffsetFactor;
        /* 0x4444 */ public float CharCamDeflectSpeed;
        /* 0x4448 */ public float CharCamMinSpeed;
        /* 0x444C */ public float CharCamRightStickX;
        /* 0x4450 */ public float CharCamRightStickY;
        /* 0x4454 */ public float FirstPersonCamHeight;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4458 */ public byte[] Padding4458;
        [NMS(Size = 0x8)]
        /* 0x4460 */ public Vector4f[] FirstPersonCamOffset;
        /* 0x44E0 */ public Vector3f FirstPersonInShipCamOffset;
        /* 0x44F0 */ public float FirstPersonFoV;
        /* 0x44F4 */ public float ThirdPersonFoV;
        /* 0x44F8 */ public float FirstPersonZoom1FoV;
        /* 0x44FC */ public float FirstPersonZoom2FoV;
        /* 0x4500 */ public float ShipFoVMin;
        /* 0x4504 */ public float ShipFoVMin2;
        /* 0x4508 */ public float ShipFoVMax;
        /* 0x450C */ public float ShipWarpFoV;
        /* 0x4510 */ public float ShipFoVMin3rdPerson;
        /* 0x4514 */ public float ShipFoVMax3rdPerson;
        /* 0x4518 */ public float ShipFoVBoost;
        /* 0x451C */ public float ShipFoVMiniJump;
        /* 0x4520 */ public float ShipFoVSpring;
        /* 0x4524 */ public float ShipMiniJumpFoVSpring;
        /* 0x4528 */ public float FoVSpring;
        /* 0x452C */ public float FoVAdjust;
        /* 0x4530 */ public bool FollowDrawCamProbes;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x4531 */ public byte[] Padding4531;
        /* 0x4534 */ public GcCameraAnimationData CameraAnimations;
        /* 0x45B8 */ public TkTextureResource AmbientDroneAnimations;
        [NMS(Size = 0x80)]
        /* 0x463C */ public string CameraAmbientAnimationsData;
        /* 0x46BC */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x46C0 */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x46C4 */ public byte[] Padding46C4;
        /* 0x46D0 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x4780 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Size = 0x4)]
        /* 0x4830 */ public TkPhysRelVectorData[] SavedCameraPositions;
        [NMS(Size = 0x4)]
        /* 0x48B0 */ public Vector4f[] SavedCameraFacing;
        /* 0x48F0 */ public GcCameraWarpSettings WarpSettings;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x4934 */ public byte[] EndPadding;
    }
}
