// <copyright file="ClassTemplate.cs" company="MicroCODE, Inc.">Copyright © 2008 MicroCODE Incorporated Troy, MI</copyright><author><Class Author's Name></author>

/*
 *      Title:    <Class Description>
 *      Module:   ClassTemplate (<Namespace>:ClassTemplate.cs)
 *      Project:  <Project Name>
 *      Customer: <Customer Name>
 *      Facility: MicroCODE Incorporated
 *      Date:     <Class Creation Date>
 *      Author:   <Class Author's Name>
 * 
 *      Copyright © 2008 MicroCODE Incorporated Troy, MI
 *
 *      This software and related materials are the property of 
 *      MicroCODE Incorporated and contain confidential and proprietary
 *      information. This software and related materials shall not be
 *      duplicated, disclosed to others, or used in any way without written 
 *      permission from MicroCODE Incorported.
 * 
 * 
 *      DESCRIPTION:
 *      ------------
 * 
 *      This module implements the MicroCODE C# Class for 'ClassTemplate' ...
 * 
 * 
 * 
 *      REFERENCES:
 *      -----------
 *
 *      1.  ".NET Framework Developer's Guide"
 *          from MSDN Web Site - Coding Guidelines summarized here.
 *          http://msdn.microsoft.com/en-us/library/ms229042.aspx 
 * 
 *      2. <... external documentation needed for this Class.>

 * 
 * 
 *  
 *      MODIFICATIONS:
 *      --------------
 *
 *  Date:         By-Group:   Rev:     Description:
 *
 *  20-Nov-2008   TJM-MCODE  {0001}    New Class Template using MSDN Guidelines and #regions, use with MicroCODE Snippets 
 *                                     for Enum, Constant, Field, Struct, Method, Operator, EventHandler, and Exception.
 *  19-Dec-2008   TJM-MCODE  {0002}    Corrected all 'StyleCop' warnings.
 *  16-Apr-2009   TJM-MCODE  {0003}    Commented out empty Finalizer for FxCop error/warning concerning performance.
 *  16-Apr-2018   TJM-MCODE  {0004}    Updates for Windows 10, .NET 7, for new application development.
 * 
 */

#region MSDN_CodingGuidelines

/*      
 *      NAMING CONVENTIONS and GUIDELINES:
 *      ----------------------------------
 *      
 *      Do choose easily readable identifier names. For example, a property named HorizontalAlignment is more readable in English than AlignmentHorizontal.
 *      Do favor readability over brevity. The property name CanScrollHorizontally is better than ScrollableX (an obscure reference to the X-axis).
 *      Do not use underscores, hyphens, or any other nonalphanumeric characters.
 *      Do not use Hungarian notation. (The practice of including a prefix in identifiers to encode some metadata about the parameter). 
 *      Do not use identifiers that conflict with keywords of widely used programming languages.
 *      Do not use abbreviations or contractions as parts of identifier names.
 *      Do not use any acronyms that are not widely accepted, and then only when necessary.
 *      Do use semantically interesting names rather than language-specific keywords for type names. For example, GetLength is a better name than GetInt.
 *      Do use a generic common language runtime (CLR) type name, rather than a language-specific name. (e.g.: Int32 vs. int)
 *
 * 
 *      Names of Common Types
 *      ---------------------
 *      The following guidelines provide naming conventions that help developers recognize the intended usage scenario for certain classes. 
 *      Where the guideline refers to types that inherit from some other type, this applies to all inheritors, not just the types that directly inherit.
 *      For example, the guideline "Do add the suffix Exception to types that inherit from Exception." means that any type that has Exception in its 
 *      inheritance hierarchy should have a name that ends in Exception. 
 *      
 *      Each of these guidelines also serves to reserve the specified suffix; unless your type meets the criteria established by the guideline, 
 *      it should not use the suffix. For example, if your type does not directly or indirectly inherit from Exception, its name must not end in Exception. 
 *      
 *      Do add the suffix 'Attribute' to custom attribute classes.
 *      - ObsoleteAttribute and AttributeUsageAttribute are type names that follow this guideline. 
 *      Do add the suffix 'EventHandler' to names of types that are used in events (such as return types of a C# event).
 *      - AssemblyLoadEventHandler is a delegate name that follows this guideline. 
 *      Do add the suffix 'Callback' to the name of a delegate that is not an event handler.
 *      Do not add the suffix Delegate to a delegate.
 *      Do add the suffix 'EventArgs' to classes that extend System.EventArgs.
 *      Do not derive from the System.Enum class; use the keyword supported by your language instead. For example, in C#, use the enum keyword.
 *      Do add the suffix 'Exception' to types that inherit from System.Exception.
 *      Do add the suffix 'Dictionary' to types that implement System.Collections.IDictionary or System.Collections.Generic.IDictionary<TKey, TValue>. 
 *      - Note that System.Collections.IDictionary is a specific type of collection, but this guideline takes precedence over the more general 
 *        collections guideline below.
 *      Do add the suffix 'Collection' to types that implement System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.IList, 
 *        System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.ICollection<T>, or System.Collections.Generic.IList<T>.
 *      Do add the suffix 'Stream' to types that inherit from System.IO.Stream.
 *      Do add the suffix 'Permission' to types that inherit from System.Security.CodeAccessPermission or implement System.Security.IPermission.
 *      
 * 
 *      Names of Generic Type Parameters 
 *      --------------------------------
 *      Generics are a major new feature of the .NET Framework version 2.0. The following guidelines cover selecting the correct names for 
 *      generic type parameters. 
 *      
 *      Do name generic type parameters with descriptive names, unless a single-letter name is completely self explanatory and a 
 *      descriptive name would not add value.
 *      
 *            IDictionary<(Of <(TKey, TValue>)>) is an example of an interface that follows this guideline. 
 *      
 *      Consider using the letter T as the type parameter name for types with one single-letter type parameter.
 *      Do prefix descriptive type parameter names with the letter T.
 *      
 *      Consider indicating constraints placed on a type parameter in the name of parameter. 
 *      For example, a parameter constrained to ISession may be called TSession.
 *      
 * 
 *
 *      CAPITALIZATION CONVENTIONS:
 *      ---------------------------
 * 
 *      Pascal Casing - the first letter in the identifier and the first letter of each subsequent concatenated word are capitalized. 
 *                      You can use Pascal case for identifiers of three or more characters. For example: BackColor
 *      Camel Casing - the first letter of an identifier is lowercase and the first letter of each subsequent concatenated word is capitalized.
 *                     For example: backColor
 *      Uppercase - All letters in the identifier are capitalized. For example: IO 
 * 
 *      Rules:  1) When an identifier consists of multiple words, do not use separators, such as underscores ("_") or hyphens ("-"), between words.
 *                 Instead, use casing to indicate the beginning of each word. 
 *              2) Do use Pascal casing for all public member, type, and namespace names consisting of multiple words.
 *              3) Do use camel casing for parameter names.
 *              4) Do not use acronyms in identifiers unless they are widely known and well understood. 
 *                 Do capitalize both characters of two-character acronyms, except the first word of a camel-cased identifier.
 *                 Do capitalize only the first character of acronyms with three or more characters, except the first word of a camel-cased identifier.
 *                 Do not capitalize any of the characters of any acronyms, whatever their length, at the beginning of a camel-cased identifier.
 *              5) Do not capitalize each word in so-called closed-form compound words. 
 *                 These are compound words written as a single word, such as "endpoint" or "doorway".
 * 
 *
 *      Identifier               Case         Example             Embedded Acronym Examples
 *      -----------------------------------------------------------------------------------------
 *      Class                    Pascal       AppDomain           UsbScanner
 *      Enumeration type         Pascal       ErrorLevel          NewVehicleID
 *      Enumeration values       Pascal       FatalError          Hhp
 *      Event                    Pascal       ValueChanged        KukaConveyorStop
 *      Exception class          Pascal       WebException        IOException, ParameterException
 *      Read-only static field   Pascal       RedValue            BigStockName
 *      Read-only const field    Upper        BIT00               DEVICE_STOPCODE
 *      Interface                Pascal       IDisposable         IUsbStoppable
 *      Method                   Pascal       Tostring            ToEipIONode
 *      Namespace                Pascal       System.Drawing      Pid.Tracking
 *      Parameter                Camel        typeName            kukaConveyor
 *      Property                 Pascal       BackColor           KukaTrimConveyor
 * 
 *      Acronyms                 Pascal       UsbIO, UsbIONode, UpsVehicle, kukaConveyor
 * 
 * 
 */

#endregion

namespace MicroCODE.Subsystem
{
    #region MSDN_NamespaceGuidelines
    // Do place only a single namespace in a C# file
    // Do use namespaces to organize types into a hierarchy of related feature areas.
    // Avoid very deep namespace hierarchies. Such hierarchies are difficult to browse as the user has to backtrack often.
    // Avoid having too many namespaces.
    // Avoid having types designed for advanced scenarios in the same namespace as types intended for common programming tasks.
    // Do not define types without specifying their namespaces.
    // Do use a namespace with the '.Design' suffix to contain types that provide design-time functionality for a base namespace.
    // Do use a namespace with the '.Permissions' suffix to contain types that provide custom permissions for a base namespace.
    // Do use a namespace with the '.Interop' suffix to contain types that provide interoperability functionality for a base namespace.
    // Do use a namespace with the '.Interop' suffix for all code in a primary interop assembly (PIA).
    #endregion

    using System;
    using System.Collections.Generic;
    using System.Text;

    #region MSDN_ClassGuidelines
    /*
        Do name classes, interfaces, and value types with nouns, noun phrases, or occasionally adjective phrases, using Pascal casing.
        Do not give class names a prefix (such as the letter C).
        - Interfaces, which should begin with the letter 'I', are the exception to this rule. (Like IDisposable).
        Consider ending the name of derived classes with the name of the base class.
        - For example, Framework types that inherit from Stream end in 'Stream', and types that inherit from Exception end in 'Exception'. 
        Do prefix interface names with the letter 'I' to indicate that the type is an interface.
        Do ensure that when defining a class/interface pair where the class is a standard implementation of the interface, the names differ 
          only by the letter 'I' prefix on the interface name.
        - For example, the Framework provides the 'IAsyncResult' interface and the 'AsyncResult' class.

         I N T E R F A C E

        Do favor defining classes over interfaces.
        Do use abstract classes instead of interfaces to decouple the contract from implementations.
        Do define an interface if you need to provide a polymorphic hierarchy of value types.
        Consider defining interfaces to achieve an effect similar to that of multiple inheritance.

         A B S T R A C T   C L A S S 

        Do not define public or protected internal constructors in abstract types.
        Do define a protected or an internal constructor in abstract classes.
        Do provide at least one concrete type that inherits from each abstract class that you ship.

         S T A T I C   C L A S S

        Do use static classes sparingly.
        Do not treat static classes as a miscellaneous bucket.
        Do not declare or override instance members in static classes.
        Do declare static classes as sealed and abstract, and add a private instance constructor, if your programming language does not 
          have built-in support for static classes.
    */
    #endregion

    /// C L A S S <summary>
    /// One sentence summary of class function...
    /// </summary>
    public class ClassTemplate
    {
        // C O N S T A N T S
        #region Constants

        #region MSDN_ConstantsGuidelines
        /*
            Do use constants to represent defintions in external legacy systems. (MCODE)
            Do reproduce the names as they exist in the legacy systems, including UPPER CASE. (MCODE)
            Avoid defining constants, follow the C# .NET Guidelines for Enumerations, Parameters, and Fields.
            Do use constant fields for constants that will never change.
            For example, the Math class defines E and PI as static constants. 
        */
        #endregion

        #endregion  // Constants

        // F I E L D S
        #region Fields

        #region MSDN_FieldGuidelines
        /*
            Do use Pascal casing in field names.
            Do name fields with nouns or noun phrases.
            Do not use a prefix for field names types or attributes.
            Do not provide instance fields that are public or protected.
            - Public and protected fields do not version well and are not protected by code access security demands. 
            - Instead of using publicly visible fields, use private fields and expose them through properties. 
            Do use constant fields for constants that will never change.
            - For example, the Math class defines E and PI as static constants. 
            - The compiler inserts the values of const fields directly into the calling code, which means that const values can never be changed
             without the risk of introducing a compatibility issue. 
            Do use public static read-only fields for predefined object instances.
            - For example, the DateTime class provides static read-only fields that you can use to obtain DateTime objects set to the maximum
             or minimal time value. See MaxValue and MinValue. 
            Do not assign instances of mutable types to read-only fields.
        */
        #endregion

        #endregion  // Fields

        // C O N S T R U C T O R
        #region Constructor

        #region MSDN_ConstructorGuidelines
        /*
            Consider providing simple, ideally default, constructors. A simple constructor has a very small number of parameters, and all parameters
            are primitive types or enumerations.
            Consider using a static factory method instead of a constructor if the semantics of the desired operation do not map directly to the
            construction of a new instance, or if following the constructor design guidelines feels unnatural.
            Do use constructor parameters as shortcuts for setting main properties.
            Do use the same name for constructor parameters and a property, if the constructor parameters are used to simply set the property. 
            The only difference between such parameters and the properties should be casing.
            Do minimal work in the constructor. Constructors should not do much work other than to capture the constructor parameters. 
            The cost of any other processing should be delayed until required.
            Do throw exceptions from instance constructors if appropriate.
            Do explicitly declare the public default constructor in classes, if such a constructor is required.
            Avoid having default constructors on structures.
            Do not call virtual members on an object inside its constructors.

            T Y P E   C O N S T R U C T O R S

            A type constructor is used to initialize static data in a type. It is called by the common language runtime (CLR) before any instances
            of the type are created. Type constructors are static and cannot take parameters. 
            Do make type constructors private.
            Do not throw exceptions from type constructors.
            Consider initializing static fields inline rather than explicitly using static constructors because the CLR can optimize the performance
            of types that do not have an explicitly defined static constructor.
        */
        #endregion

        /// <summary>
        /// Initializes a new instance of the ClassTemplate class.
        /// </summary>
        public ClassTemplate()
        {
            // Constructor logic here...
        }

        #endregion  // Constructor

        // D E S T R U C T O R
        #region Finalizer

        /*
        /// <summary>
        /// Finalizes an instance of the ClassTemplate class.
        /// </summary>
        ~ClassTemplate()
        {
            // destructor logic here... "Finalizers should be avoided where possible, to avoid the additional performance overhead 
            //                           involved in tracking object lifetime."
        }
        */

        #endregion  // Finalizer

        // D E L E G A T E S
        #region Delegates

        #region MSDN_EventGuidelines
        /*
            Do not add the suffix Delegate to a delegate.
            Do name event handlers (delegates used as types of events) with the EventHandler suffix.
            Do use System.EventHandler<T> instead of manually creating new delegates to be used as event handlers.
            Do add the suffix 'EventHandler' to names of types that are used in events (such as return types of a C# event).
            - AssemblyLoadEventHandler is a delegate name that follows this guideline. 
            Do add the suffix 'Callback' to the name of a delegate that is not an event handler.
       */
        #endregion

        #endregion  // Delegates

        // E V E N T S
        #region Events

        #region MSDN_EventGuidelines
        /*
            Do name events with a verb or a verb phrase.
            Do give event names a concept of before and after, using the present and past tense.
            - For example, a close event that is raised before a window is closed would be called Closing and one that is raised after the window is closed would be called Closed.
            Do not use Before or After prefixes or suffixes to indicate pre and post events.
            Do name event handlers (delegates used as types of events) with the EventHandler suffix.
            Do use two parameters named sender and e in event handler signatures.
            - The sender parameter should be of type Object, and the e parameter should be an instance of or inherit from EventArgs. 
            Do name event argument classes with the EventArgs suffix.
            Do names classes that inherit 'EventArgs' 'Eventname' + 'EventArgs': EventNameEventArgs. 
            Do use the raise terminology for events rather than fire or trigger.
            Do use System.EventHandler<T> instead of manually creating new delegates to be used as event handlers.
            Consider using a derived class of System.EventArgs as the event argument, unless you are absolutely sure the event will never
            need to carry any data to the event-handling method, in which case you can use the System.EventArgs type directly.
            Do use a protected virtual method to raise each event. This is applicable only to non-static events on unsealed classes, 
            not to structures, sealed classes, or static events.
            Do use a parameter that is typed as the event argument class to the protected method that raises an event. The parameter should be named e.
            Do not pass null as the sender parameter when raising a non-static event.
            Do not pass null as the event data parameter when raising an event.
            Do be prepared for arbitrary code executing in the event-handling method.
            Consider raising events that the end user can cancel. This applies only to pre-events.
        */
        #endregion

        #endregion  // Events

        // E N U M E R A T I O N S
        #region Enumerators

        #region MSDN_EnumeratorsGuidelines
        /*
            Do not use a prefix on enumeration value names. For example, do not use a prefix such as ad for ADO enumerations, or rtf for rich text 
              enumerations, and so on. This also implies that you should not include the enumeration type name in the enumeration value names. 
            Do not use 'Enum' as a suffix on enumeration types.
            Do not add 'Flags' as a suffix on the names of flags enumerations.
            Do use a singular name for an enumeration, unless its values are bit fields.
            Do use a plural name for enumerations with bit fields as values, also called flags enumerations.
            Do use an enumeration to strongly type parameters, properties, and return values that represent sets of values.
            Do favor using an enumeration instead of static constants.
            Do not use an enumeration for open sets such as the operating system version.
            Do not define reserved enumeration values that are intended for future use.
            Avoid publicly exposing enumerations with only one value.
            Do not include sentinel values in enumerations.
            Do provide a value of zero on simple enumerations.
            Consider using System.Int32 (the default data type in most programming languages) as the underlying data type of an enumeration  
             unless any of the following is true:
            - The enumeration is a flags enumeration, and you have more than 32 flags or expect to have more in the future. 
            - The underlying type needs to be different than Int32 for easier interoperability with unmanaged code expecting different size enumerations. 
            - A smaller underlying type would result in substantial savings in space. If you expect an enumeration to be used mainly as an argument 
             for flow of control, the size makes little difference. The size savings might be significant if: 
            - You expect the enumeration to be used as a field in a very frequently instantiated structure or class. 
            - You expect users to create large arrays or collections of enumeration instances. 
            - You expect a large number of instances of the enumeration to be serialized. 
            Do name flags enumerations with plural nouns or noun phrases. Simple enumerations should be named with singular nouns or noun phrases.
            Do not extend System.Enum directly.
            Consider adding values to enumerations despite a small compatibility risk.
            To minimize the code that breaks due to adding values to an existing enumeration, you can implement new members that return the 
            full set of values and mark the existing members (that return the original set of values) using the ObsoleteAttribute attribute.

            F L A G S

            Do apply the 'System.FlagsAttribute' to flags enumerations. Do not apply this attribute to simple enumerations.
            Do use powers of two for a flags enumeration's values so they can be freely combined using the bitwise OR operation.
            Consider providing special enumeration values for commonly used combinations of flags.
            Avoid creating flags enumerations when certain combinations of values are invalid.
            Avoid setting a flags enumeration value to zero, unless the value is used to indicate that all flags are cleared. 
             Such a value should be named appropriately as described in the next guideline.
            Do name the zero value of flags enumerations 'None'. For a flags enumeration, the value must always mean all flags are cleared.
        */
        #endregion

        #endregion  // Enumerators

        // I N T E R F A C E S 
        #region Interfaces

        #region MSDN_InterfaceGuidelines
        /*
            D E S I G N   P A T T E R N S

            [Finalize and Dispose]
            Note that even when you provide explicit control using Dispose, you should provide implicit cleanup using the Finalize method. 
            Finalize provides a backup to prevent resources from permanently leaking if the programmer fails to call Dispose.

            F I N A L I Z E

            Implement Finalize only on objects that require finalization. There are performance costs associated with Finalize methods. 
            If you require a Finalize method, consider implementing IDisposable to allow users of your class to avoid the cost of invoking 
            the Finalize method. 
            Do not make the Finalize method more visible. It should be protected, not public. 
            An object's Finalize method should free any external resources that the object owns. Moreover, a Finalize method should release only 
            resources that the object has held onto. The Finalize method should not reference any other objects. 
            Do not directly call a Finalize method on an object other than the object's base class. This is not a valid operation in the 
            C# programming language. 

            D I S P O S E

            Implement the dispose design pattern on a type that encapsulates resources that explicitly need to be freed. Users can free external 
            resources by calling the public Dispose method. 
            Implement the dispose design pattern on a base type that commonly has derived types that hold onto resources, even if the base type does not.
            If the base type has a Close method, often this indicates the need to implement Dispose. In such cases, do not implement a Finalize method 
            on the base type. Finalize should be implemented in any derived types that introduce resources that require cleanup. 
            Free any disposable resources a type owns in its Dispose method. 
            After Dispose has been called on an instance, prevent the Finalize method from running by calling the GC..::.SuppressFinalize. 
            The exception to this rule is the rare situation in which work must be done in Finalize that is not covered by Dispose. 
            Call the base class's Dispose method if it implements IDisposable. 
            Do not assume that Dispose will be called. Unmanaged resources owned by a type should also be released in a Finalize method in the event 
            that Dispose is not called. 
            Throw an ObjectDisposedException from instance methods on this type (other than Dispose) when resources are already disposed. 
            This rule does not apply to the Dispose method because it should be callable multiple times without throwing an exception. 
            Propagate the calls to Dispose through the hierarchy of base types. The Dispose method should free all resources held by this object and 
            any object owned by this object. For example, you can create an object such as a TextReader that holds onto a Stream and an Encoding, 
            both of which are created by the TextReader without the user's knowledge. Furthermore, both the Stream and the Encoding can acquire 
            external resources. When you call the Dispose method on the TextReader, it should in turn call Dispose on the Stream and the Encoding, 
            causing them to release their external resources. 
            Consider not allowing an object to be usable after its Dispose method has been called. Re-creating an object that has already been disposed
            is a difficult pattern to implement. 
            Allow a Dispose method to be called more than once without throwing an exception. The method should do nothing after the first call.

            T I M E O U T

            Use time-outs to specify the maximum time a caller is willing to wait for completion of a method call. 
        */
        #endregion

        #endregion  // Interfaces

        // P R O P E R T I E S
        #region Properties

        #region MSDN_PropertyGuidelines
        /*
            Do name properties using a noun, noun phrase, or an adjective.
            Do not use properties that match the names of Get methods.
            Do name Boolean properties with an affirmative phrase (CanSeek instead of CantSeek); that is the 'ON' condition.
            - Optionally, you can also prefix Boolean properties with Is, Using, Can, or Has, but only where it adds value.
            Consider giving a property the same name as its type or enumneration.
            Do create read-only properties if the caller should not be able to change the value of the property.
            Be aware that the mutability of the property type affects what the end user can change. 
            - For example, if you define a read-only property that returns a read/write collection, the end user cannot assign a different 
            collection to the property but can modify the elements in the collection. 
            Do not provide set-only properties.
            If the property getter cannot be provided, use a method to implement the functionality instead. The method name should begin with Set
            followed by what would have been the property name. For example, AppDomain has a method called SetCachePath instead of having 
            a set-only property called CachePath. 
            Do provide sensible default values for all properties, ensuring that the defaults do not result in a security hole or an extremely
            inefficient design.
            Do allow properties to be set in any order even if this results in a temporary invalid object state.
            Do preserve the previous value if a property setter throws an exception.
            Avoid throwing exceptions from property getters.

            I N D E X E R S

            Consider using indexers to provide access to data stored in an internal array.
            Consider providing indexers on types representing collections of items.
            Avoid indexed properties with more than one parameter.
            Avoid indexers with parameter types other than System.Int32, System.Int64, System.string, System.Object, enumerations, or generic type parameters.
            Do use the name Item for indexed properties unless there is an obviously better name (for example, see the System.string.Chars(System.Int32) property).
            Do not provide both an indexer and methods that are semantically equivalent.

            C H A N G E   N O T I F I C A T I O N

            Consider raising change notification events when property values in high-level APIs (usually designer components) are modified.
            Consider raising change notification events when the value of a property changes through external forces.
        */
        #endregion

        #region ClassName
        /// <summary>
        /// Gets the name of this class for status events.
        /// </summary>
        /// <value>The name of this class.</value>
        public string ClassName
        {
            get { return typeof(ClassTemplate).Name; }
        }
        #endregion

        #region FullClassName
        /// <summary>
        /// Gets the the fully qualified name of this class for status events, including namespace.
        /// </summary>
        /// <value>The fully qualified name of this class.</value>
        public string FullClassName
        {
            get { return typeof(ClassTemplate).FullName; }
        }
        #endregion

        #endregion  // Properties

        // S T A T I C   M E T H O D S
        #region StaticMethods

        #endregion  // StaticMethods

        // I N D E X E R S
        #region Indexers

        #region MSDN_IndexerGuidelines
        /*
            Indexers enable objects to be indexed in a similar manner to arrays. 
            A get accessor returns a value. A set accessor assigns a value. 
            The this keyword is used to define the indexers. 
            The value keyword is used to define the value being assigned by the set indexer. 
            Indexers do not have to be indexed by an integer value; it is up to you how to define the specific look-up mechanism. 
            Indexers can be overloaded. 
            Indexers can have more than one formal parameter, for example, when accessing a two-dimensional array. 
        */
        #endregion

        #endregion  // Indexers

        // O P E R A T O R   O V E R L O A D S
        #region OperatorOverloads

        #region MSDN_OperatorGuidelines
        /*
            Operator overloads allow types to be combined and compared using operators such as "+", "-", "=", and "!=". By adding operator 
            overloads to a type, you allow developers to use the type as though it were a built-in primitive type. Operator overloading should
            be done only when the meaning of the operation is intuitive for the type (for example, to support adding two instances of a type 
            that represents a numerical value). Operator overloading should not be used to provide a syntactic shortcut for non-intuitive operations. 

            Avoid defining operator overloads, except in types that should work like primitive (built-in) types.
            Consider defining operator overloads in a type that should work like a primitive type.
            Do define operator overloads in structures that represent numbers (such as System.Decimal).
            Do not be clever when defining operator overloads. Operator overloading is useful in cases where it is immediately obvious
            what the result of the operation will be. For example, it makes sense to be able to subtract one System.DateTime object from 
            another System.DateTime object and get a System.TimeSpan object. However, it is not appropriate to use the logical union operator
            to union two database queries, or to use the shift operator to write to a stream.
            Do not provide operator overloads unless at least one of the operands is of the type defining the overload.
            Do overload operators in a symmetric fashion.
            Consider providing methods with friendly names corresponding to each overloaded operator.

              C# operator symbol  Name of alternative method  Name of operator 
              --------------------------------------------------------------------
              Not defined         ToXxx or FromXxx            op_Implicit 
              Not defined         ToXxx or FromXxx            op_Explicit 
              + (binary)          Add                         op_Addition 
              - (binary)          Subtract                    op_Subtraction 
              * (binary)          Multiply                    op_Multiply 
              /                   Divide                      op_Division 
              %                   Mod                         op_Modulus 
              ^                   Xor                         op_ExclusiveOr 
              & (binary)          BitwiseAnd                  op_BitwiseAnd 
              |                   BitwiseOr                   op_BitwiseOr 
              &&                  And                         op_LogicalAnd 
              ||                  Or                          op_LogicalOr 
              =                   Assign                      op_Assign 
              <<                  LeftShift                   op_LeftShift 
              >>                  RightShift                  op_RightShift 
              Not defined         LeftShift                   op_SignedRightShift 
              Not defined         RightShift                  op_UnsignedRightShift 
              ==                  Equals                      op_Equality 
              >                   CompareTo                   op_GreaterThan 
              <                   CompareTo                   op_LessThan 
              !=                  Equals                      op_Inequality 
              >=                  CompareTo                   op_GreaterThanOrEqual 
              <=                  CompareTo                   op_LessThanOrEqual 
              *=                  Multiply                    op_MultiplicationAssignment 
              -=                  Subtract                    op_SubtractionAssignment 
              ^=                  Xor                         op_ExclusiveOrAssignment 
              <<=                 LeftShift                   op_LeftShiftAssignment 
              %=                  Mod                         op_ModulusAssignment 
              +=                  Add                         op_AdditionAssignment 
              &=                  BitwiseAnd                  op_BitwiseAndAssignment 
              |=                  BitwiseOr                   op_BitwiseOrAssignment 
              ,                   Comma                       op_Comma 
              /=                  Divide                      op_DivisionAssignment 
              --                  Decrement                   op_Decrement 
              ++                  Increment                   op_Increment 
              - (unary)           Negate                      op_UnaryNegation 
              + (unary)           Plus                        op_UnaryPlus 
              ~                   OnesComplement              op_OnesComplement 

            C O N V E R S I O N   O P E R A T O R S

            Do not provide a conversion operator if such conversion is not clearly expected by the end users.
            Do not define conversion operators outside of a type�s domain.
            Do not provide an implicit conversion operator if the conversion is potentially lossy.
            Do not throw exceptions from implicit casts.
            Do throw System.InvalidCastException if a call to a cast operator results in a lossy conversion and the contract of 
            the operator does not allow lossy conversions.
        */
        #endregion

        #endregion  // OperatorOverloads

        // I M P L E M E N T A T I O N S
        #region Implementations

        #endregion  // Implementations

        // M E T H O D S
        #region Methods

        #region MSDN_MethodGuidelines
        /*
            Do give methods names that are verbs or verb phrases.
              Typically methods act on data, so using a verb to describe the action of the method makes it easier for developers to understand what
              the method does. When defining the action performed by the method, be careful to select a name that provides clarity from the 
              developer's perspective. 
            Do not select a verb that describes how the method works; in other words, do not use implementation details for your method name. 
            
             G E N E R I C S
          
            Do name generic type parameters with descriptive names, unless a single letter name is completely self explanatory and a descriptive name would not add value.
            Consider using T as the type parameter name for types with one single letter type parameter.
            Do prefix descriptive type parameter names with �T�.
            Consider indicating constraints placed on a type parameter in the name of parameter. For example, a parameter constrained to ISession may be called TSession.

         
             P A R A M E T E R S 
            
            Do use parameter names that indicate what data or functionality is affected by the parameter. 
            Do use camel casing in parameter names.
            Do use descriptive parameter names.
            Do use names which, when coupled with its type, describe the parameter's usage. 
            Do use names based on a parameter's meaning rather than the parameter's type.
            Do use the least-derived parameter type that provides the functionality required by the member.
            Do not use reserved parameters.
            Do not use publicly exposed methods that take pointers, arrays of pointers, or multidimensional arrays as parameters.
            Do place all 'out' parameters after all of the pass-by-value and ref parameters (excluding parameter arrays), 
              even if this results in an inconsistency in parameter ordering between overloads.
            Do be consistent in naming parameters when overriding members or implementing interface members.
            
            Do use enumerations if a member would otherwise have two or more Boolean parameters.
            Do not use Booleans unless you are absolutely sure there will never be a need for more than two values.
            
            
             P A R A M E T E R   V A L I D A T I O N
            
            Do validate arguments passed to public, protected, or explicitly implemented members. 
            Throw System.ArgumentException, or one of its derived classes, if the validation fails.
            Do throw System.ArgumentNullException if a null argument is passed but the member does not support null arguments.
            Do validate enumeration parameters.
            Do not use System.Enum.IsDefined(System.Type,System.Object) for enumeration range checks as it is based on the runtime type
              of the enumeration, which can change from version to version.
            Do be aware that mutable arguments passed may have changed after they were validated.
            
            
             P A S S I N G   P A R A M E T E R S
            
            Avoid using 'out' or 'ref' reference parameters. Working with members that define out or reference parameters requires the understanding pointers.
            Do not pass reference types by reference. Passing an object by reference allows the method to replace the object with a different instance. 
            
            
             V A R I A B L E   N U M B E R   O F   P A R A M E T E R S
            
            Arrays are used to pass a variable number of parameters to a member. Some languages, such as C#, provide a keyword that decorates 
              an array that is used to pass variable arguments.
            Consider adding the 'params' keyword to array parameters if you expect the end users to pass a small number of elements.
            Do not use params arrays if the caller would almost always already have the input in an array.
            Do not use params arrays if the array is modified by the member taking the params array parameter.
            Consider using the 'params' keyword in a simple overload, even if a more complex overload cannot use it.
            Do try to order parameters to make it possible to use the 'params' keyword.
            Consider providing special overloads and code paths for calls with a small number of arguments in extremely performance-sensitive APIs.
            Do be aware that 'null' could be passed as a params array argument.
            Do not use the 'varargs' methods, otherwise known as the ellipsis.
            
            
             P O I N T E R S
            
            Do provide an alternative for any member that takes a pointer argument, as pointers are not CLS-compliant.
            Avoid doing expensive argument checking of pointer arguments.
            Do follow common pointer-related conventions when designing members with pointers.
            
            
             O V E R L O A D S
            
            Do try to use descriptive parameter names to indicate the default value used by simpler overloads.
            Avoid arbitrarily varying parameter names in overloads. If a parameter in one overload represents the same input as a 
              parameter in another overload, the parameters should have the same name.
            Do be consistent in the ordering of parameters in overloaded members. Parameters with the same name should appear in the
              same position in all overloads.
            Do make only the longest overload virtual if extensibility is required. 
              Shorter overloads should simply call through to a longer overload.
            Do not use ref or out modifiers to overload members.
            Do allow null to be passed for optional arguments. If a method takes optional arguments that are
              reference types, allow null to be passed to indicate that the default value should be used. This avoids the problem of 
              having to check for null before calling a member.
            Do use member overloading rather than defining members with default arguments. Default arguments are not CLS-compliant and 
              cannot be used from some languages.
            
            
             U S A G E
            
            [Arrays vs. Collections]
            Class library designers might need to make difficult decisions about when to use an array and when to return a collection. 
              Although these types have similar usage models, they have different performance characteristics. In general, you should use a 
              collection when Add, Remove, or other methods for manipulating the collection are supported. 
            Do not return an internal instance of an array.
            
            [Properties that Return Arrays]
            You should use collections to avoid code inefficiencies caused by properties that return arrays. 
            
            [Fields that Return Arrays]
            Do not use readonly fields of arrays.
            
            [Using Indexed Properties in Collections]
            Use an indexed property only as a default member of a collection class or interface. Do not create families of functions in 
            non-collection types. A pattern of methods, such as Add, Item, and Count, signals that the type should be a collection.

            [Returning Empty Arrays]
            string and Array properties should never return a null reference. Null can be difficult to understand in this context. 
        */
        #endregion

        /* Public Methods */
        #region PublicMethods

        #endregion

        /* ProtectedMethods */
        #region Protected Methods
        /// <summary>
        /// The actual clean-up code for Class.
        /// </summary>
        /// <param name="disposing">Indicates whether or not the object is being disposed.</param>
        protected virtual new void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Close any common stuff
                base.Dispose(disposing);

                //// Close / Dispose of specific stuff
            }
        }
        #endregion

        /* Private Static Methods */
        #region PrivateStaticMethods

        #endregion

        /* Private Methods */
        #region PrivateMethods

        #endregion

        #endregion  // Methods

        // E V E N T H A N D L E R S
        #region EventHandlers

        #region MSDN_EventGuidelines
        /*
            Do name events with a verb or a verb phrase.
            Do give event names a concept of before and after, using the present and past tense.
            - For example, a close event that is raised before a window is closed would be called Closing and one that is raised after the window is closed would be called Closed.
            Do not use Before or After prefixes or suffixes to indicate pre and post events.
            Do name event handlers (delegates used as types of events) with the EventHandler suffix.
            Do use two parameters named sender and e in event handler signatures.
            - The sender parameter should be of type Object, and the e parameter should be an instance of or inherit from EventArgs. 
            Do name event argument classes with the EventArgs suffix.
            Do names classes that inherit 'EventArgs' 'Eventname' + 'EventArgs': EventNameEventArgs. 
            Do use the raise terminology for events rather than fire or trigger.
            Do use System.EventHandler<T> instead of manually creating new delegates to be used as event handlers.
            Consider using a derived class of System.EventArgs as the event argument, unless you are absolutely sure the event will never
            need to carry any data to the event-handling method, in which case you can use the System.EventArgs type directly.
            Do use a protected virtual method to raise each event. This is applicable only to non-static events on unsealed classes, 
            not to structures, sealed classes, or static events.
            Do use a parameter that is typed as the event argument class to the protected method that raises an event. The parameter should be named e.
            Do not pass null as the sender parameter when raising a non-static event.
            Do not pass null as the event data parameter when raising an event.
            Do be prepared for arbitrary code executing in the event-handling method.
            Consider raising events that the end user can cancel. This applies only to pre-events.
        */
        #endregion

        #endregion  // EventHandlers

        // E X C E P T I O N S
        #region Exceptions

        #region MSDN_ExceptionGuidelines
        /*
            Exceptions are thrown when a member cannot successfully do what it is designed to do. This is known as execution failure. 
            Do not return error codes. Exceptions are the primary means of reporting errors in frameworks.
            Do report execution failures by throwing exceptions. If a member cannot successfully do what it is designed to do, 
            that should be considered an execution failure and an exception should be thrown.
            Consider terminating the process by calling System.Environment.FailFast(System.string) (a .NET Framework version 2.0 feature)
            instead of throwing an exception, if your code encounters a situation where it is unsafe to continue executing.
            Do not use exceptions for normal flow of control, if possible. Except for system failures and operations with potential race conditions,
            framework designers should design APIs so that users can write code that does not throw exceptions. For example, you can provide a way
            to check preconditions before calling a member so that users can write code that does not throw exceptions.
            Consider the performance implications of throwing exceptions.
            Do document all exceptions thrown by publicly callable members because of a violation of the member contract (rather than a system failure)
            and treat them as part of your contract. Exceptions that are a part of the contract should not change from one version to the next.
            Do not have public members that can either throw or not throw exceptions based on some option.
            Do not have public members that return exceptions as the return value or as an out parameter.
            Consider using exception builder methods. It is common to throw the same exception from different places. To avoid code bloat, use helper
            methods that create exceptions and initialize their properties.
            Do not throw exceptions from exception filter blocks. When an exception filter raises an exception, the exception is caught by the common
            language runtime (CLR), and the filter returns false. This behavior is indistinguishable from the filter executing and returning false 
            explicitly and is therefore very difficult to debug.
            Avoid explicitly throwing exceptions from finally blocks. Implicitly thrown exceptions resulting from calling methods that throw are acceptable.

            E X C E P T I O N   T Y P E

            Consider throwing existing exceptions residing in the System namespaces instead of creating custom exception types.
            Do create and throw custom exceptions if you have an error condition that can be programmatically handled in a different way than
            any other existing exceptions. Otherwise, throw one of the existing exceptions.
            Do not create and throw new exceptions just to have your team's exception.
            Do throw the most specific (the most derived) exception that is appropriate. For example, if a method receives a null argument,
            it should throw System.ArgumentNullException instead of its base type System.ArgumentException.

            E X C E P T I O N   W R A P P I N G 

            To wrap an exception, you specify it as the inner exception of a new exception and then throw the new exception. 
            This practice should be used only in situations where the original exception is not meaningful to the person who receives the exception.
            Consider wrapping specific exceptions thrown from a lower layer in a more appropriate exception, if the lower layer exception does not 
            make sense in the context of the higher-layer operation.
            Avoid catching and wrapping non-specific exceptions.
            Do specify the inner exception when wrapping exceptions.

            E R R O R   M E S S A G E S

            Do provide a rich and meaningful message text targeted at the developer when throwing an exception. The message should explain 
            the cause of the exception and clearly describe what needs to be done to avoid the exception.
            Do ensure that exception messages are grammatically correct. Top-level exception handlers may show the exception message to 
            application end users.
            Do ensure that each sentence of the message text ends with a period ("."). This way code that displays exception messages to
            the user does not have to handle the case where a developer forgot the final period, which is relatively cumbersome and expensive.
            Avoid question marks ("?") and exclamation points ("!") in exception messages.
            Do not disclose security-sensitive information in exception messages without demanding appropriate permissions.
            Consider localizing the exception messages thrown by your components if you expect your components to be used by developers 
            speaking different languages.

            E X C E P T I O N   H A N D L I N G

            Do not handle errors by catching non-specific exceptions, such as System.Exception, System.SystemException, and so on, in framework code.
            Avoid handling errors by catching non-specific exceptions, such as System.Exception, System.SystemException, and so on, in application code.
            There are cases when handling errors in applications is acceptable, but such cases are rare.
            Do not exclude any special exceptions when catching for the purpose of transferring exceptions.
            Consider catching specific exceptions when you understand why it will be thrown in a given context.
            Do not overuse catch. Exceptions should often be allowed to propagate up the call stack.
            Do use try-finally and avoid using try-catch for cleanup code. In well-written exception code, try-finally is far more common than try-catch.
            Do prefer using an empty throw when catching and re-throwing an exception. This is the best way to preserve the exception call stack.
            Do not handle non-CLS-compliant exceptions (exceptions that do not derive from System.Exception) using a parameterless catch block. 
            Languages that support exceptions that are not derived from Exception are free to handle these non-CLS compliant exceptions.

            S T A N D A R D   E X C E P T I O N S

            <Exception> and <SystemException> 
            Do not throw System.Exception or System.SystemException.
            Do not catch System.Exception or System.SystemException in framework code, unless you intend to re-throw.
            Avoid catching System.Exception or System.SystemException, except in top-level exception handlers.

            <ApplicationException>
            Do derive custom exceptions from the T:System.Exception class rather than the T:System.ApplicationException class.
            It was originally thought that custom exceptions should derive from the ApplicationException class; however, 
            this has not been found to add significant value. For more information, see Best Practices for Handling Exceptions. 

            <InvalidOperationException>
            Do throw a System.InvalidOperationException exception if in an inappropriate state. System.InvalidOperationException should be thrown if a property set or a method call is not appropriate given the object's current state. For example, writing to a System.IO.FileStream that has been opened for reading should throw a System.InvalidOperationException exception.
            This exception should also be thrown when the combined state of a set of related objects is invalid for the operation. 

            <ArgumentException>, <ArgumentNullException>, and <ArgumentOutOfRangeException>
            Do throw System.ArgumentException or one of its subtypes if bad arguments are passed to a member. Prefer the most-derived exception type if applicable.
            Do set the System.ArgumentException.ParamName property when throwing System.ArgumentException or one of its derived types. This property stores the name of the parameter that caused the exception to be thrown. Note that the property can be set using one of the constructor overloads.
            Do use value for the name of the implicit value parameter of property setters.
            Do not allow publicly callable APIs to explicitly or implicitly throw System.NullReferenceException, System.AccessViolationException, System.InvalidCastException, or System.IndexOutOfRangeException. Do argument checking to avoid throwing these exceptions. Throwing these exceptions exposes implementation details of your method that may change over time.

            <StackOverflowException>
            Do not explicitly throw System.StackOverflowException. This exception should be explicitly thrown only by the common language runtime (CLR).
            Do not catch System.StackOverflowException. It is extremely difficult to programmatically handle a stack overflow. 
            You should allow this exception to terminate the process and use debugging to determine the source of the problem. 

            <OutOfMemoryException>
            Do not explicitly throw System.OutOfMemoryException. This exception should be thrown only by the CLR infrastructure.

            <ComException> and <SEHException>
            Do not explicitly throw System.Runtime.InteropServices.COMException or System.Runtime.InteropServices.SEHException. These exceptions should be thrown only by the CLR infrastructure.
            Do not catch System.Runtime.InteropServices.SEHException explicitly.

            <ExecutionEngineException>
            Do not explicitly throw System.ExecutionEngineException.

            C U S T O M   E X C E P T I O N S

            Avoid deep exception hierarchies.
            Do derive exceptions from System.Exception or one of the other common base exceptions.
            Do end exception class names with the Exception suffix.
            Do make exceptions serializable. An exception must be serializable to work correctly across application domain and remoting boundaries.
            Do provide (at least) the following common constructors on all exceptions. Make sure the names and types of the parameters are the same those used in the following code example.
            Do report security-sensitive information through an override of System.Object.Tostring only after demanding an appropriate permission. 
            If the permission demand fails, return a string that does not include the security-sensitive information.
            Do store useful security-sensitive information in private exception state. Ensure that only trusted code can get the information.
            Consider providing exception properties for programmatic access to extra information (besides the message string) relevant to the exception.


            E X C E P T I O N S   - P E R F O R M A N C E

            Throwing exceptions can negatively impact performance. For code that routinely fails, you can use design patterns to minimize performance issues. 
            Do not use error codes because of concerns that exceptions might affect performance negatively.
            Consider the Tester-Doer pattern for members that may throw exceptions in common scenarios to avoid performance problems related to exceptions.
            Consider the TryParse pattern for members that may throw exceptions in common scenarios to avoid performance problems related to exceptions.
            Do provide an exception-throwing member for each member using the TryParse pattern.
        */
        #endregion

        #endregion  // Exceptions

        // S T R U C T U R E S
        #region Structures

        #region MSDN_StructureGuidelines
        /*
            Do not provide a default constructor for a structure.
            Do implement System.IEquatable`1 on value types.
            Do ensure that a state where all instance data is set to zero, false, or null (as appropriate) is valid.
            Do not explicitly extend System.ValueType.
            Consider defining a structure instead of a class if instances of the type are small and commonly short-lived or are 
              commonly embedded in other objects.
            Do not define a structure unless the type has all of the following characteristics:
            - It logically represents a single value, similar to primitive types (integer, double, and so on). 
            - It has an instance size smaller than 16 bytes. 
            - It is immutable. 
            - It will not have to be boxed frequently. 
        */
        #endregion

        #endregion  // Structures

        // N E S T E D  T Y P E S
        #region NestedTypes

        #region MSDN_NestedTypeGuidelines
        /*
            Do use nested types when the relationship between the nested type and its outer type is such that member accessibility 
            semantics are desirable.
            Do not use public nested types as a logical grouping construct; use namespaces for this.
            Avoid publicly exposed nested types. The only exception to this is when variables of the nested type need to be declared
            in rare scenarios such as subclassing or other advanced customization scenarios.
            Do not use nested types if the type is likely to be referenced outside of the declaring type.
            Do not use nested types if they need to be instantiated by client code. If a type has a public constructor, it should probably not be nested.
            Do not define a nested type as a member of an interface. Many languages do not support such a construct.
        */
        #endregion

        #endregion
    }
}

