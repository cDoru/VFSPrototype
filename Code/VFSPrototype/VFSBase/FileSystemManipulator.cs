﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFSBase
{
    public class FileSystemManipulator : IFileSystemManipulator
    {
        private readonly FileSystem _fileSystem;

        public FileSystemManipulator(FileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        private ISet<Folder> _folders
        {
            get { return _fileSystem.Root.Folders; }
        }

        public IEnumerable<string> Folders (string path)
        {
            var folders = new Queue<string>(path.Split('/'));
            return _fileSystem.Root.GetFolder(folders).Folders.Select(folder => folder.Name);
        }

        public bool IsDirectory(string path)
        {
            throw new System.NotImplementedException();
        }

        public void CreateFolder(string path)
        {
            var folders = new Queue<string>(path.Split('/'));
            _fileSystem.Root.CreateFolder(folders);
        }

        public void Delete(string path)
        {
            var folders = new Queue<string>(path.Split('/'));
            _fileSystem.Root.Delete(folders);
        }

        public void Move (string source, string dest)
        {
            var sourceFolders = new Queue<string>(source.Split('/'));
            IIndexNode node = _fileSystem.Root.Delete(sourceFolders);

            var last = dest.LastIndexOf('/');
            var folder = last >= 0 ? dest.Substring(0, last) : "";
            var name = last >= 0 ? dest.Substring(last+1) : dest;
            var destFolders = new Queue<string>(folder.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries));

            node.Name = name;
            _fileSystem.Root.Insert(destFolders, node);

        }

        
        public bool Exists(string path)
        {
            var folders = new Queue<string>(path.Split('/'));
            return _fileSystem.Root.Exists(folders);
        }


        public void ImportFile(string source, string dest)
        {
            var path = new Queue<string>(dest.Split('/'));   
            _fileSystem.Root.ImportFile(path, source);
        }

        public void ExportFile(string source, string dest)
        {
            var path = new Queue<string>(source.Split('/'));
            _fileSystem.Root.ExportFile(path, dest);
        }

        public void Copy(string source, string dest)
        {
            throw new System.NotImplementedException();
        }

        public void MoveFile(string source, string dest)
        {
            throw new System.NotImplementedException();
        }
    }
}
