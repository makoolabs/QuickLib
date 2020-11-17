Audio(保持默认):
    Volume Rolloff Scale:衰减系数，该值越大，音量衰减就越快。相反，值越小，衰减越慢。值为 1 将模拟“真实世界”。
    Doppler Factor:设置多普勒效应的听觉影响。值为 0 将其禁用。值为 1 表示对于快速移动的对象应该能听得见声音
    Default Speaker Mode:Stereo(立体声)，Surround(环绕),Prologic DTS(杜比音效)
    System Sample Rate:设置输出采样率。如果设置为 0，Unity 将使用系统的采样率
    DSP Buffer Size:设置 DSP 缓冲区的大小来优化延迟或性能
    Disable Unity Audio:启用此属性可在独立构建中停用音频系统。
    Virtualize Effect:启用此属性可动态关闭为节省 CPU 而剔除的 AudioSources 上的效果和空间音响。
Editor(1,2,3,4,6更改设置):
    1)Version Control:选择Visible Meta Files,以方便git版本管理
    2)Asset Serizlization:选择Force Text,方便git冲突时合并
    3)Asset Pipeline: Mode 选择Version2 资源管理版本
    Cache Server:CacheServer选择，视情况可选。
    Prefab Editing Environments:在预制件模式下将一个场景指定为常规预制件（即具有常规变换组件的预制件）的编辑环境,这样便可以根据选择的背景（而不是空场景）编辑预制件。
    Graphics:
        Show LightMap Resolution Overlay:此设置与烘焙全局光照 (Baked Global Illumination) 类别中的绘制模式 (Draw Modes) 关联。启用此设置后，Unity 会在这些绘制模式之上绘制一个棋盘覆盖层，其中每个棋盘格区块对应一个纹素。此设置可在光照贴图时用于检查场景的纹素密度
        Use legacy Light Probe sample counts:使用固定光照探针样本计数通过渐进光照贴图 (Progressive Lightmapper) 进行烘焙
    4)Sprite Packer:
        如果不影响启动速度直接选Always Enabled,否则选Enabled For Builds
    ETC Texture Compressor:保持默认
    5)Line Endings For New Scripts:
        Mode:选择Unix，以便统一文件行尾格式
    6)Streaming Settings:纹理串流,PlayMode,Edit Mode全勾选
    Shader Compilation:Shader异步编译，勾选
Graphics(高端设备启用级联阴影等，低端设备禁用，注意Shader变体,渲染路径,预加载Shader列表):
    Scriptable Render Pipeline Settings:此处可以定义一系列命令来精确控制场景的渲染方式（而不是使用 Unity 提供的默认渲染管线）(HRDP,LRDP,SRDP,URDP)
    Camera Settings:
        Transparency Sort Mode:定义按对象在特定轴上的距离渲染对象的顺序：(保持默认按摄像机模式排序)
    Tier Settings:
        对标准着色器，反射探针，阴影，光照，HDR,渲染路径，全局光照进行设置
    Built-in shader settings:
        No Support 禁用此计算。如果不使用延迟着色或光照，请使用此设置。这样可以节省构建的游戏数据文件中的一些空间。
        Built-in Shader 使用 Unity 的内置着色器进行计算。此为默认值
        使用自己的兼容着色器进行计算。这样可以对延迟渲染进行深度自定义
    Always-included Shaders:
        指定始终与项目一起存储（即使场景中没有任何对象实际使用这些着色器）的着色器列表。应将流式 AssetBundles 使用的着色器添加到此列表中来确保可以访问这些着色器，这一点非常重要
    Shader stripping:automatic,由Unity决定跳过哪些着色器变体
    实例化着色器变体:Strip Unused,Unity 会剥离禁用了 Enable instancing 的材质未引用的着色器
    Shader preloading:指定要在加载游戏时预加载的着色器变体集合资源的列表。此列表中指定的着色器变体会在应用程序的整个生命周期内加载。可使用此属性来预加载使用频率极高的着色器
Physics(如果不是物理要求高的，保持默认):
Player(主要设置，分平台设置):
    Company Name
    Product Name
    Version
    Default Icon
    启动画面 (Splash Screen):Unity 启动画面在所有平台上都是一致的。它会迅速显示，在显示的同时，第一个场景在后台异步加载。这与您自己的介绍性画面或动画有所不同，您自己的画面或动画可能需要一段时间才能出现；这是因为 Unity 必须首先加载整个引擎和第一个场景，然后才会显示它们
    分平台设置
Preset Manager(一般不用，使用可提高效率,可以为项目设置通用的，开新项目直接导入):
    使用预设可以指定新组件和资源导入器的默认属性。不能为项目设置、偏好设置或本机资源（如材质、动画或 SpriteSheets）设置默认属性。
    将组件添加到游戏对象或者将新资源添加到项目时，Unity 使用默认的预设来设置新项的属性。默认预设会覆盖 Unity 出厂默认设置
Quality(根据游戏和设备平台选择):
    Unity 允许设置其尝试渲染的图形质量级别。一般来说，高质量是以帧率为代价的，因此最好不要在移动设备或旧硬件上以最高质量为目标，因为它容易对游戏运行产生不利影响
    抗锯齿
抗锯齿可改善多边形边缘的外观，使它们不会产生“锯齿现象”，而是在屏幕上获得平滑的显示效果。但是，它会导致显卡的性能成本升高并使用更多的视频内存（尽管没有 CPU 成本）。抗锯齿的程度决定了多边形边缘的平滑程度（以及消耗的视频内存量）
    内置硬件抗锯齿功能不适用于延迟着色和 HDR 渲染。对于这些情况，需要使用抗锯齿图像效果
    软粒子
    软粒子在与其他场景几何体的交叉处附近淡出。这种视觉效果将大幅提升，但计算成本更高（更复杂的像素着色器），并且仅适用于支持深度纹理的平台。此外，必须使用延迟着色或旧版延迟光照渲染路径，或使摄像机从脚本渲染深度纹理
    Shadows
    最大 LOD 级别
Unity 在构建中不会使用 LOD 低于 MaximumLOD 级别的模型，而是将其忽略（这样可以节省存储和内存空间）
    撕裂
显示设备上的图片不会持续更新，而是定期更新，很大程度上就像 Unity 中的帧更新一样。但是，Unity 的更新不一定与显示器的更新同步，因此 Unity 有可能在显示器仍在渲染前一帧时发出新的帧。这会导致在屏幕上发生帧变化的位置处产生称为“撕裂”的视觉瑕疵
    可以使 Unity 仅在显示设备未更新的时间段（即所谓的“垂直空白”）切换帧。Quality 设置中的 V Sync Count 选项将帧开关与设备的垂直空白同步，还可以选择与每隔一个垂直空白同步。如果游戏需要多个设备更新来完成帧的渲染，后者可能会很有用。
Script Execution Order(特定项目中有用)
    该顺序单独应用于事件函数的每个类别，所以 Unity 按指定顺序调用其在一帧内需要调用的任何 Awake 函数，随后按相同顺序来调用活动游戏对象的任何 Update 函数
    此设置窗口中指定的执行顺序不会影响以 RuntimeInitializeOnLoadMethod 属性标记的函数的顺序。（无法指定运行时初始化的顺序。）
Tags and Layers(特定项目中有用)
时间 (Time)(特定项目或调试时加快或减慢有用)

