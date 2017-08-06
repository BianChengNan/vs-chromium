﻿// Copyright 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System;
using System.Collections.Generic;
using VsChromium.Server.FileSystem;
using VsChromium.Server.FileSystemScanSnapshot;

namespace VsChromium.Server.FileSystemDatabase {
  public interface IFileDatabaseFactory {
    IFileDatabase CreateEmpty();

    IFileDatabase CreateIncremental(
      IFileDatabase previousFileDatabase,
      FileSystemSnapshot previousSnapshot,
      FileSystemSnapshot newSnapshot,
      FullPathChanges fullPathChanges,
      Action<IFileDatabase> onIntermadiateResult);

    IFileDatabase CreateWithChangedFiles(
      IFileDatabase previousFileDatabase,
      IEnumerable<ProjectFileName> changedFiles,
      Action onLoading,
      Action onLoaded);
  }
}