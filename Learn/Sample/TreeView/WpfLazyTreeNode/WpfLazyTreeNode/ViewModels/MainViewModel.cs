﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using WpfLazyTreeNode.Models;
using WpfLazyTreeNode.Utils;

namespace WpfLazyTreeNode.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public LazyTreeNode CreateNode(string key, string text, ExplorerType explorerType)
        {
            var Images = ToggleImageUtils.GetExplorers(explorerType);
            var node = new LazyTreeNode { Key = key, Text = text };
            node.OpenedImage = Images.opendedImage;
            node.ClosedImage = Images.closedImage;
            node.OnExpanded += Node_OnExpanded;

            if(DirectoryUtils.IsDirectoryOrFileExists(key))
            {
                node.AddDummyNode();
            }

            return node;
        }

        private void Node_OnExpanded(LazyTreeNode node)
        {
            // 하위 디렉토리
            foreach (var di in DirectoryUtils.GetDirectories(node.Key))
            {
                node.Children.Add(CreateNode(di.FullName, di.Name, ExplorerType.Directory));
            }

            // 하위 파일
            foreach (var fi in DirectoryUtils.GetFiles(node.Key))
            {
                node.Children.Add(CreateNode(fi.FullName, fi.Name, ExplorerType.File));
            }
        }

        private void AddDriveNodes()
        {
            foreach (var driveInfo in DriveInfo.GetDrives())
            {
                PathNodes.Add(CreateNode(driveInfo.Name, driveInfo.Name, ExplorerType.Drive));
            }
        }

        public MainViewModel()
        {
            PathNodes = new();

            AddDriveNodes();
        }

        public ObservableCollection<LazyTreeNode> PathNodes { get; set; }
    }
}
