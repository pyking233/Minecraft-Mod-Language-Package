﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Spider {
    public class Info : DownloadMod{
        [JsonPropertyName("mod_id")] public string ModId { get; set; }
        [JsonPropertyName("mod_domain")] public string[] Domain { get; set; }
        [JsonPropertyName("has_language_folder")] public bool HasLang { get; set; }
        [JsonPropertyName("has_chinese")] public bool HasChinese { get; set; }
        [JsonPropertyName("lang_path")] public string[] LangList { get; set; }
        [JsonPropertyName("lastUpdateTime")] public DateTimeOffset LastUpdateTime { get; set; }
    }
    
    public class Addon
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("authors")]
        public List<Author> Authors { get; set; }

        [JsonPropertyName("attachments")]
        public List<Attachment> Attachments { get; set; }

        [JsonPropertyName("websiteUrl")]
        public Uri WebsiteUrl { get; set; }

        [JsonPropertyName("gameId")]
        public long GameId { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("defaultFileId")]
        public long DefaultFileId { get; set; }

        [JsonPropertyName("downloadCount")]
        public double DownloadCount { get; set; }

        [JsonPropertyName("latestFiles")]
        public List<LatestFile> LatestFiles { get; set; }

        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }

        [JsonPropertyName("status")]
        public long Status { get; set; }

        [JsonPropertyName("primaryCategoryId")]
        public long PrimaryCategoryId { get; set; }

        [JsonPropertyName("categorySection")]
        public CategorySection CategorySection { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("gameVersionLatestFiles")]
        public List<GameVersionLatestFile> GameVersionLatestFiles { get; set; }

        [JsonPropertyName("isFeatured")]
        public bool IsFeatured { get; set; }

        [JsonPropertyName("popularityScore")]
        public double PopularityScore { get; set; }

        [JsonPropertyName("gamePopularityRank")]
        public long GamePopularityRank { get; set; }

        [JsonPropertyName("primaryLanguage")]
        public string PrimaryLanguage { get; set; }

        [JsonPropertyName("gameSlug")]
        public string GameSlug { get; set; }

        [JsonPropertyName("gameName")]
        public string GameName { get; set; }

        [JsonPropertyName("portalName")]
        public string PortalName { get; set; }

        [JsonPropertyName("dateModified")]
        public DateTimeOffset DateModified { get; set; }

        [JsonPropertyName("dateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonPropertyName("dateReleased")]
        public DateTimeOffset DateReleased { get; set; }

        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonPropertyName("isExperiemental")]
        public bool IsExperiemental { get; set; }
    }

    public class Attachment
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("projectId")]
        public long ProjectId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("isDefault")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("status")]
        public long Status { get; set; }
    }

    public class Author
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("projectId")]
        public long ProjectId { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("projectTitleId")]
        public long? ProjectTitleId { get; set; }

        [JsonPropertyName("projectTitleTitle")]
        public string ProjectTitleTitle { get; set; }

        [JsonPropertyName("userId")]
        public long UserId { get; set; }

        [JsonPropertyName("twitchId")]
        public long? TwitchId { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("categoryId")]
        public long CategoryId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonPropertyName("parentId")]
        public long ParentId { get; set; }

        [JsonPropertyName("rootId")]
        public long RootId { get; set; }

        [JsonPropertyName("projectId")]
        public long ProjectId { get; set; }

        [JsonPropertyName("avatarId")]
        public long AvatarId { get; set; }

        [JsonPropertyName("gameId")]
        public long GameId { get; set; }
    }

    public class CategorySection
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("gameId")]
        public long GameId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("packageType")]
        public long PackageType { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("initialInclusionPattern")]
        public string InitialInclusionPattern { get; set; }

        [JsonPropertyName("extraIncludePattern")]
        public object ExtraIncludePattern { get; set; }

        [JsonPropertyName("gameCategoryId")]
        public long GameCategoryId { get; set; }
    }

    public class GameVersionLatestFile
    {
        [JsonPropertyName("gameVersion")]
        public string GameVersion { get; set; }

        [JsonPropertyName("projectFileId")]
        public long ProjectFileId { get; set; }

        [JsonPropertyName("projectFileName")]
        public string ProjectFileName { get; set; }

        [JsonPropertyName("fileType")]
        public long FileType { get; set; }

        [JsonPropertyName("gameVersionFlavor")]
        public object GameVersionFlavor { get; set; }
    }

    public class LatestFile
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("fileName")]
        public string FileName { get; set; }

        [JsonPropertyName("fileDate")]
        public DateTimeOffset FileDate { get; set; }

        [JsonPropertyName("fileLength")]
        public long FileLength { get; set; }

        [JsonPropertyName("releaseType")]
        public long ReleaseType { get; set; }

        [JsonPropertyName("fileStatus")]
        public long FileStatus { get; set; }

        [JsonPropertyName("downloadUrl")]
        public Uri DownloadUrl { get; set; }

        [JsonPropertyName("isAlternate")]
        public bool IsAlternate { get; set; }

        [JsonPropertyName("alternateFileId")]
        public long AlternateFileId { get; set; }

        [JsonPropertyName("dependencies")]
        public List<Dependency> Dependencies { get; set; }

        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }

        [JsonPropertyName("modules")]
        public List<Module> Modules { get; set; }

        [JsonPropertyName("packageFingerprint")]
        public long PackageFingerprint { get; set; }

        [JsonPropertyName("gameVersion")]
        public List<string> GameVersion { get; set; }

        [JsonPropertyName("sortableGameVersion")]
        public List<SortableGameVersion> SortableGameVersion { get; set; }

        [JsonPropertyName("installMetadata")]
        public object InstallMetadata { get; set; }

        [JsonPropertyName("changelog")]
        public object Changelog { get; set; }

        [JsonPropertyName("hasInstallScript")]
        public bool HasInstallScript { get; set; }

        [JsonPropertyName("isCompatibleWithClient")]
        public bool IsCompatibleWithClient { get; set; }

        [JsonPropertyName("categorySectionPackageType")]
        public long CategorySectionPackageType { get; set; }

        [JsonPropertyName("restrictProjectFileAccess")]
        public long RestrictProjectFileAccess { get; set; }

        [JsonPropertyName("projectStatus")]
        public long ProjectStatus { get; set; }

        [JsonPropertyName("renderCacheId")]
        public long RenderCacheId { get; set; }

        [JsonPropertyName("fileLegacyMappingId")]
        public object FileLegacyMappingId { get; set; }

        [JsonPropertyName("projectId")]
        public long ProjectId { get; set; }

        [JsonPropertyName("parentProjectFileId")]
        public object ParentProjectFileId { get; set; }

        [JsonPropertyName("parentFileLegacyMappingId")]
        public object ParentFileLegacyMappingId { get; set; }

        [JsonPropertyName("fileTypeId")]
        public object FileTypeId { get; set; }

        [JsonPropertyName("exposeAsAlternative")]
        public object ExposeAsAlternative { get; set; }

        [JsonPropertyName("packageFingerprintId")]
        public long PackageFingerprintId { get; set; }

        [JsonPropertyName("gameVersionDateReleased")]
        public DateTimeOffset GameVersionDateReleased { get; set; }

        [JsonPropertyName("gameVersionMappingId")]
        public long GameVersionMappingId { get; set; }

        [JsonPropertyName("gameVersionId")]
        public long GameVersionId { get; set; }

        [JsonPropertyName("gameId")]
        public long GameId { get; set; }

        [JsonPropertyName("isServerPack")]
        public bool IsServerPack { get; set; }

        [JsonPropertyName("serverPackFileId")]
        public object ServerPackFileId { get; set; }

        [JsonPropertyName("gameVersionFlavor")]
        public object GameVersionFlavor { get; set; }
    }

    public class Dependency
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("addonId")]
        public long AddonId { get; set; }

        [JsonPropertyName("type")]
        public long Type { get; set; }

        [JsonPropertyName("fileId")]
        public long FileId { get; set; }
    }

    public class Module
    {
        [JsonPropertyName("foldername")]
        public string Foldername { get; set; }

        [JsonPropertyName("fingerprint")]
        public long Fingerprint { get; set; }

        [JsonPropertyName("type")]
        public long Type { get; set; }
    }

    public class SortableGameVersion
    {
        [JsonPropertyName("gameVersionPadded")]
        public string GameVersionPadded { get; set; }

        [JsonPropertyName("gameVersion")]
        public string GameVersion { get; set; }

        [JsonPropertyName("gameVersionReleaseDate")]
        public DateTimeOffset GameVersionReleaseDate { get; set; }

        [JsonPropertyName("gameVersionName")]
        public string GameVersionName { get; set; }
    }
}