using System;
using System.Collections.Generic;

public class AbductionMission : Mission
{
    public Officer TargetOfficer { get; set; }

    /// <summary>
    /// Default constructor used for deserialization.
    /// </summary>
    public AbductionMission()
        : base()
    // @TODO: Move the success probability variables to configs.
    {
        Name = "Abduction";
        ParticipantSkill = MissionParticipantSkill.Combat;
        QuadraticCoefficient = 0.005558;
        LinearCoefficient = 0.7656;
        ConstantTerm = 20.15;
        MinSuccessProbability = 1;
        MaxSuccessProbability = 100;
        MinTicks = 15;
        MaxTicks = 20;
    }

    /// <summary>
    /// Constructor used when initializing the AbductionMission with participants and owner.
    /// </summary>
    public AbductionMission(
        string ownerInstanceId,
        string targetInstanceId,
        List<IMissionParticipant> mainParticipants,
        List<IMissionParticipant> decoyParticipants,
        Officer targetOfficer
    // @TODO: Move the success probability variables to configs.
    )
        : base(
            "Abduction",
            ownerInstanceId,
            targetInstanceId,
            mainParticipants,
            decoyParticipants,
            MissionParticipantSkill.Combat,
            quadraticCoefficient: 0.0002622,
            linearCoefficient: 0.4955,
            constantTerm: 49.76,
            minSuccessProbability: 1,
            maxSuccessProbability: 100,
            minTicks: 15,
            maxTicks: 20
        )
    {
        TargetOfficer = targetOfficer;
    }

    /// <summary>
    ///
    /// </summary>
    protected override void OnSuccess(Game game)
    {
        // Logic for mission success
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="game"></param>
    public override bool CanContinue(Game game)
    {
        return false;
    }
}
