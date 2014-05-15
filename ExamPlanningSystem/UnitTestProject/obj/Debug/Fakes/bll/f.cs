// <assemblyHash>71ace2a5</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=12.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias bll;
extern alias dalc;
extern alias mqttf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("BLL", false)]
[assembly: global::System.Reflection.AssemblyCompany("")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("BLL")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace BE.Fakes
{
    /// <summary>Shim type of BE.Class</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(bll::BE.Class))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of Class")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimClass
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<bll::BE.Class>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimClass()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimClass(bll::BE.Class instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::BE.Fakes.ShimClass.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::BE.Fakes.ShimClass.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(bll::BE.Class), value);
            }
        }

        /// <summary>Sets the shim of Class.Class()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<bll::BE.Class> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(bll::BE.Class), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }
    }
}
namespace BE.Fakes
{
    /// <summary>Stub type of BE.Class</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(bll::BE.Class))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of Class")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubClass
      : bll::BE.Class
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<bll::BE.Class>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubClass()
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubClass</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
namespace BLL.Fakes
{
    /// <summary>Shim type of BLL.BLLClass</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(bll::BLL.BLLClass))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of BLLClass")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimBLLClass
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<bll::BLL.BLLClass>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimBLLClass()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimBLLClass(bll::BLL.BLLClass instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the shim of BLLClass.addClass(Class _class)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<bll::BLL.BLLClass, dalc::DALC.Class> addClassClass
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("addClass", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(bll::BLL.BLLClass), (object)null, 
                         "addClass", typeof(void), new global::System.Type[]{typeof(dalc::DALC.Class)});
                }
            }

            /// <summary>Sets the shim of BLLClass.getClass(Int32 classID)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<bll::BLL.BLLClass, int, dalc::DALC.Class> getClassInt32
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("getClass", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(bll::BLL.BLLClass), (object)null, 
                         "getClass", typeof(dalc::DALC.Class), new global::System.Type[]{typeof(int)});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::BLL.Fakes.ShimBLLClass.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::BLL.Fakes.ShimBLLClass.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(bll::BLL.BLLClass), value);
            }
        }

        /// <summary>Sets the shim of BLLClass.BLLClass()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<bll::BLL.BLLClass> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(bll::BLL.BLLClass), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of BLLClass.addClass(Class _class)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<dalc::DALC.Class> addClassClass
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("addClass", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<bll::BLL.BLLClass, dalc::DALC.Class>(value)), 
                                                                                                    typeof(bll::BLL.BLLClass), base.Instance, "addClass", typeof(void), new global::System.Type[]{typeof(dalc::DALC.Class)});
            }
        }

        /// <summary>Sets the shim of BLLClass.getClass(Int32 classID)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int, dalc::DALC.Class> getClassInt32
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("getClass", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<bll::BLL.BLLClass, int, dalc::DALC.Class>(value)), 
                                                                                                    typeof(bll::BLL.BLLClass), base.Instance, "getClass", typeof(dalc::DALC.Class), new global::System.Type[]{typeof(int)});
            }
        }
    }
}
namespace BLL.Fakes
{
    /// <summary>Stub type of BLL.BLLClass</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(bll::BLL.BLLClass))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of BLLClass")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubBLLClass
      : bll::BLL.BLLClass
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<bll::BLL.BLLClass>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubBLLClass()
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubBLLClass</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
