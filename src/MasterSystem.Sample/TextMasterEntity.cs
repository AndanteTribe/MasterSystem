using GameKernel;
using Localization;
using MasterMemory;
using MasterSystem.Abstractions;
using MasterSystem.Sample.Enums;
using MessagePack;

namespace MasterSystem.Sample;

[MemoryTable(nameof(TextMasterEntity)), MessagePackObject]
[FileName("text.csv")]
public class TextMasterEntity
{
    /// <summary>
    /// マスターID.
    /// </summary>
    [PrimaryKey, Key(0)]
    public required MasterId<TextCategory> Id { get; init; }

    /// <summary>
    /// グループ（テキストカテゴリー）.
    /// </summary>
    [SecondaryKey(0), NonUnique, IgnoreMember]
    public TextCategory Group => Id.Group;

    /// <summary>
    /// ローカライズフォーマット.
    /// </summary>
    [Key(1)]
    public required LocalizeFormat Format { get; init; }

    /// <summary>
    /// ローカライズテキスト.
    /// </summary>
    /// <remarks>
    /// フォーマットなしテキストはこちらから取得可能.
    /// </remarks>
    [IgnoreMember]
    public string Text => Format.ToString();
}