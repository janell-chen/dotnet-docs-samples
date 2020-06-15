﻿// Copyright 2020 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// [START pubsub_test_topic_permissions]

using Google.Cloud.Iam.V1;
using Google.Cloud.PubSub.V1;
using System.Collections.Generic;

public class TestTopicIamPermissionsSample
{
    public TestIamPermissionsResponse TestTopicIamPermissions(string projectId, string topicId)
    {
        List<string> permissions = new List<string>
        {
            "pubsub.topics.get",
            "pubsub.topics.update"
        };
        TestIamPermissionsRequest request = new TestIamPermissionsRequest
        {
            ResourceAsResourceName = TopicName.FromProjectTopic(projectId, topicId),
            Permissions = { permissions }
        };
        PublisherServiceApiClient publisher = PublisherServiceApiClient.Create();
        TestIamPermissionsResponse response = publisher.TestIamPermissions(request);
        return response;
    }
}
// [END pubsub_test_topic_permissions]
