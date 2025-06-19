using System;
using System.Collections.Generic;

namespace WpfMqttSubApp.Models;

public partial class Schedule
{
    public int SchIdx { get; set; }

    /// <summary>
    /// 공장코드
    /// </summary>
    public string PlantCode { get; set; } = null!;

    /// <summary>
    /// 공정계획일
    /// </summary>
    public DateOnly SchDate { get; set; }

    public int LoadTime { get; set; }

    /// <summary>
    /// 계획된 시작시간
    /// </summary>
    public TimeOnly? SchStartTime { get; set; }

    /// <summary>
    /// 계획된 종료시간
    /// </summary>
    public TimeOnly? SchEndTime { get; set; }

    /// <summary>
    /// 생산설비 ID
    /// </summary>
    public string? SchFacilityId { get; set; }

    /// <summary>
    /// 목표수량
    /// </summary>
    public int? SchAmount { get; set; }

    /// <summary>
    /// 작성일
    /// </summary>
    public DateTime? RegDt { get; set; }

    /// <summary>
    /// 수정일
    /// </summary>
    public DateTime? ModDt { get; set; }

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();
}
