// <copyright file="ClassTemplate.cs" company="MicroCODE Incorporated">Copyright © 2018-2022 MicroCODE, Inc. Troy, MI</copyright><author>Timothy J. McGuire</author>
// D O C U M E N T A T I O N
#region Documenation
#region Preamble
/*
 *      Title:    <Class Description>
 *      Module:   ClassTemplate (<Namespace>:ClassTemplate.cs)
 *      Project:  <Project Name>
 *      Customer: <Customer Name>
 *      Facility: MicroCODE Incorporated
 *      Date:     <Class Creation Date>
 *      Author:   <Class Author's Name>
 *
 *      Designed and Coded: 1998-2022 MicroCODE Incorporated
 *
 *      This software and related materials are the property of
 *      MicroCODE Incorporated and contain confidential and proprietary
 *      information. This software and related materials shall not be
 *      duplicated, disclosed to others, or used in any way without the
 *      written of MicroCODE Incorported.
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
 *      1. <... external documentation needed for this Class.>
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
 *  DD-Mmm-YYYY   XYZ-GROUP  {0001}    Describe reason for creating or modifying class...
 *
 *
 *
 */
#endregion
#endregion

namespace MicroCODE
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    /// C L A S S <summary>
    /// One sentence summary of class function...
    /// </summary>
    public class ClassTemplate : IDisposable
    {
        // P U B L I C   C O N S T A N T S
        #region PublicConstants

        #endregion  // PublicConstants

        // I N T E R N A L S
        #region Internals

        #endregion  // Internals

        // P R I V A T E   C O N S T A N T S
        #region PrivateConstants

        #endregion  // PrivateConstants

        // F I E L D S
        #region Fields

        private bool _isDisposed;  // Set true when object has been disposed
        private Mutex _propertyMutex = new Mutex();  // For thread safe operations on class properties

        #endregion  // Fields

        // C O N S T R U C T O R
        #region Constructor

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

        #endregion  // Delegates

        // E V E N T S
        #region Events

        #endregion  // Events

        // E N U M E R A T I O N S
        #region Enumerators

        #endregion  // Enumerators

        // I N T E R F A C E S
        #region Interfaces

        #endregion  // Interfaces

        // P R O P E R T I E S
        #region Properties

        /* Public Static Properties */
        #region ClassName
        /// <summary>
        /// Gets the name of this class for status events.
        /// </summary>
        /// <value>The name of this class.</value>
        public static string ClassName
        {
            get { return typeof(ClassTemplate).Name; }
        }
        #endregion

        #region FullClassName
        /// <summary>
        /// Gets the the fully qualified name of this class for status events, including namespace.
        /// </summary>
        /// <value>The fully qualified name of this class.</value>
        public static string FullClassName
        {
            get { return typeof(ClassTemplate).FullName; }
        }
        #endregion

        /* Public Properties */

        /* Public Protected Properties */

        /* Internal Properties */

        /* Private Static Properties */

        /* Private Properties */

        #endregion  // Properties

        // S T A T I C   M E T H O D S
        #region StaticMethods

        #endregion  // StaticMethods

        // I N D E X E R S
        #region Indexers

        #endregion  // Indexers

        // O P E R A T O R   O V E R L O A D S
        #region OperatorOverloads

        #endregion  // OperatorOverloads

        // I M P L E M E N T A T I O N S
        #region Implementations

        #region IDisposable
        /// <summary>
        /// IDisposable implementation.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
        #endregion

        #endregion  // Implementations

        // M E T H O D S
        #region Methods

        /* Public Methods */
        #region PublicMethods

        #endregion

        /* Internal Methods */
        #region InternalMethods

        #endregion

        /* Protected Methods */
        #region ProtectedMethods

        /// <summary>
        /// The actual clean-up code for the Class.
        /// </summary>
        /// <param name="disposing">Indicates whether or not the object is being disposed.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                try
                {
                    if (App.HasValidHandle(_propertyMutex))
                    {
                        // Wait for any property access in process to complete...
                        _propertyMutex.WaitOne();

                        _isDisposed = true;  // we can't use this anymore

                        //// Note: After disposing of the 'Property' and 'IO' Mutexes
                        ////       all access to Object Properties and I/O Devices invalid.

                        _propertyMutex.ReleaseMutex();
                        _propertyMutex.Close();
                    }
                    _propertyMutex = null;
                }
                catch (Exception exception)
                {
                    App.Exception(FullClassName, exception);
                }
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

        #endregion  // EventHandlers

        // E X C E P T I O N S
        #region Exceptions

        #endregion  // Exceptions

        // S T R U C T U R E S
        #region Structures

        #endregion  // Structures

        // N E S T E D  T Y P E S
        #region NestedTypes

        /* Public Static Classes */

        /* Public Classes */

        #region NestedClassTemplate
        /// C L A S S <summary>
        /// One sentence summary of class function...
        /// </summary>
        public class NestedClassTemplate
        {
            // P U B L I C   C O N S T A N T S
            #region PublicConstants

            #endregion  // PublicConstants

            // I N T E R N A L S
            #region Internals

            #endregion  // Internals

            // P R I V A T E   C O N S T A N T S
            #region PrivateConstants

            #endregion  // PrivateConstants

            // F I E L D S
            #region Fields

            #endregion  // Fields

            // C O N S T R U C T O R
            #region Constructor

            /// <summary>
            /// Initializes a new instance of the ClassTemplate class.
            /// </summary>
            public NestedClassTemplate()
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
            ~NestedClassTemplate()
            {
                // destructor logic here... "Finalizers should be avoided where possible, to avoid the additional performance overhead
                //                           involved in tracking object lifetime."
            }
            */

            #endregion  // Finalizer

            // D E L E G A T E S
            #region Delegates

            #endregion  // Delegates

            // E V E N T S
            #region Events

            #endregion  // Events

            // E N U M E R A T I O N S
            #region Enumerators

            #endregion  // Enumerators

            // I N T E R F A C E S
            #region Interfaces

            #endregion  // Interfaces

            // P R O P E R T I E S
            #region Properties

            /* Public Static Properties */
            #region ClassName
            /// <summary>
            /// Gets the name of this class for status events.
            /// </summary>
            /// <value>The name of this class.</value>
            public static string ClassName
            {
                get { return typeof(NestedClassTemplate).Name; }
            }
            #endregion

            #region FullClassName
            /// <summary>
            /// Gets the the fully qualified name of this class for status events, including namespace.
            /// </summary>
            /// <value>The fully qualified name of this class.</value>
            public static string FullClassName
            {
                get { return typeof(NestedClassTemplate).FullName; }
            }
            #endregion

            /* Public Properties */

            /* Public Protected Properties */

            /* Internal Properties */

            /* Private Static Properties */

            /* Private Properties */

            #endregion  // Properties

            // S T A T I C   M E T H O D S
            #region StaticMethods

            #endregion  // StaticMethods

            // I N D E X E R S
            #region Indexers

            #endregion  // Indexers

            // O P E R A T O R   O V E R L O A D S
            #region OperatorOverloads

            #endregion  // OperatorOverloads

            // I M P L E M E N T A T I O N S
            #region Implementations

            #endregion  // Implementations

            // M E T H O D S
            #region Methods

            /* Public Methods */
            #region PublicMethods

            #endregion

            /* Internal Methods */
            #region InternalMethods

            #endregion

            /* Protected Methods */
            #region ProtectedMethods

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

            #endregion  // EventHandlers

            // E X C E P T I O N S
            #region Exceptions

            #endregion  // Exceptions

            // S T R U C T U R E S
            #region Structures

            #endregion  // Structures

            // N E S T E D  T Y P E S
            #region NestedTypes

            /* Public Static Classes */

            /* Public Classes */

            /* Private Static Classes */

            /* Private Classes */

            #endregion
        }
        #endregion  // NestedClassTemplate

        /* Private Static Classes */

        /* Private Classes */

        #endregion
    }
}