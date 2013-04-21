﻿using System;
using System.Collections.Generic;
using VFSBase.Exceptions;
using VFSBase.Implementation;

namespace VFSBase.Interfaces
{
    internal interface IFileSystem : IDisposable
    {
        /// <summary>
        /// Enumerates all files and folders of the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        /// <returns>IEnumerable{Folder}.</returns>
        IEnumerable<IIndexNode> List(Folder folder);

        /// <summary>
        /// Enumerates all folders of the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        /// <returns>IEnumerable{Folder}.</returns>
        IEnumerable<Folder> Folders(Folder folder);

        /// <summary>
        /// Enumerates all files of the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        /// <returns>IEnumerable{VFSFile}.</returns>
        IEnumerable<VFSFile> Files(Folder folder);

        /// <summary>
        /// Determines whether a file or folder with a specified name exists in a specified folder.
        /// </summary>
        /// <param name="folder">The folder where to search.</param>
        /// <param name="name">The name of the file or folder to search for.</param>
        /// <returns><c>true</c> if file or folder with name exists, <c>false</c> otherwise</returns>
        bool Exists(Folder folder, string name);

        /// <summary>
        /// Finds the element with a specified name in the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        /// <param name="name">The name of the file or folder to search for.</param>
        /// <returns>The IIndexNode if found, <c>null</c> otherwise.</returns>
        IIndexNode Find(Folder folder, string name);

        /// <summary>
        /// Creates a new folder with a specified name in the folder parent folder.
        /// </summary>
        /// <param name="parentFolder">The parent folder.</param>
        /// <param name="name">The name of the new folder.</param>
        /// <returns>The newly created folder.</returns>
        /// <exception cref="AlreadyExistsException">If the folder with <paramref name="name"/> already exists</exception>
        Folder CreateFolder(Folder parentFolder, string name);

        /// <summary>
        /// Imports the specified nodeToCopy (file or folder) from the host system recursively into the folder <paramref name="destination"/>.
        /// </summary>
        /// <param name="source">The nodeToCopy.</param>
        /// <param name="destination">The destination.</param>
        /// <param name="name">The name.</param>
        void Import(string source, Folder destination, string name);

        /// <summary>
        /// Exports the specified nodeToCopy (file or folder) recursively to the specified destination on the host file system.
        /// </summary>
        /// <param name="source">The nodeToCopy.</param>
        /// <param name="destination">The destination.</param>
        void Export(IIndexNode source, string destination);

        /// <summary>
        /// Copies the specified nodeToCopy recursively to the destination folder.
        /// </summary>
        /// <param name="nodeToCopy">The nodeToCopy to copy.</param>
        /// <param name="destination">The destination where to copy the nodeToCopy to.</param>
        /// <param name="nameOfCopiedElement">The name of the copied element.</param>
        void Copy(IIndexNode nodeToCopy, Folder destination, string nameOfCopiedElement);

        /// <summary>
        /// Deletes the specified nodeToCopy recursively.
        /// </summary>
        /// <param name="node">The nodeToCopy to be deleted.</param>
        void Delete(IIndexNode node);

        /// <summary>
        /// Moves the specified nodeToCopy to the destination folder.
        /// </summary>
        /// <param name="node">To move.</param>
        /// <param name="destination">The destination.</param>
        /// <param name="name">The new name of the nodeToCopy (can be the same as nodeToCopy.Name).</param>
        void Move(IIndexNode node, Folder destination, string name);

        /// <summary>
        /// Gets the root folder.
        /// </summary>
        /// <value>The root.</value>
        RootFolder Root { get; }

        /// <summary>
        /// Gets the file system options.
        /// </summary>
        /// <value>The file system options.</value>
        FileSystemOptions FileSystemOptions { get; }
    }
}