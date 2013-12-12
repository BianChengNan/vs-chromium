﻿// Copyright 2013 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using VsChromiumCore.Ipc;

namespace VsChromiumServer.Ipc {
  public interface IIpcRequestDispatcher {
    void ProcessRequestAsync(IpcRequest request);
  }
}