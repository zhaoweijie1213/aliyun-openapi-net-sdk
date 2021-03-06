/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeAvailableResourceResponseUnmarshaller
    {
        public static DescribeAvailableResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAvailableResourceResponse describeAvailableResourceResponse = new DescribeAvailableResourceResponse();

			describeAvailableResourceResponse.HttpResponse = context.HttpResponse;
			describeAvailableResourceResponse.RequestId = context.StringValue("DescribeAvailableResource.RequestId");

			List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone> describeAvailableResourceResponse_availableZones = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone>();
			for (int i = 0; i < context.Length("DescribeAvailableResource.AvailableZones.Length"); i++) {
				DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone availableZone = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone();
				availableZone.RegionId = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].RegionId");
				availableZone.ZoneId = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].ZoneId");

				List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion> availableZone_supportedEngineVersions = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion>();
				for (int j = 0; j < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions.Length"); j++) {
					DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion supportedEngineVersion = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion();
					supportedEngineVersion.Version = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions["+ j +"].Version");

					List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine> supportedEngineVersion_supportedEngines = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine>();
					for (int k = 0; k < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions["+ j +"].SupportedEngines.Length"); k++) {
						DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine supportedEngine = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine();
						supportedEngine.Engine = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions["+ j +"].SupportedEngines["+ k +"].Engine");

						List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType> supportedEngine_supportedNodeTypes = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType>();
						for (int l = 0; l < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions["+ j +"].SupportedEngines["+ k +"].SupportedNodeTypes.Length"); l++) {
							DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType supportedNodeType = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType();
							supportedNodeType.NodeType = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions["+ j +"].SupportedEngines["+ k +"].SupportedNodeTypes["+ l +"].NodeType");
							supportedNodeType.NetworkTypes = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions["+ j +"].SupportedEngines["+ k +"].SupportedNodeTypes["+ l +"].NetworkTypes");

							List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource> supportedNodeType_availableResources = new List<DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource>();
							for (int m = 0; m < context.Length("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions["+ j +"].SupportedEngines["+ k +"].SupportedNodeTypes["+ l +"].AvailableResources.Length"); m++) {
								DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource availableResource = new DescribeAvailableResourceResponse.DescribeAvailableResource_AvailableZone.DescribeAvailableResource_SupportedEngineVersion.DescribeAvailableResource_SupportedEngine.DescribeAvailableResource_SupportedNodeType.DescribeAvailableResource_AvailableResource();
								availableResource.InstanceClass = context.StringValue("DescribeAvailableResource.AvailableZones["+ i +"].SupportedEngineVersions["+ j +"].SupportedEngines["+ k +"].SupportedNodeTypes["+ l +"].AvailableResources["+ m +"].InstanceClass");

								supportedNodeType_availableResources.Add(availableResource);
							}
							supportedNodeType.AvailableResources = supportedNodeType_availableResources;

							supportedEngine_supportedNodeTypes.Add(supportedNodeType);
						}
						supportedEngine.SupportedNodeTypes = supportedEngine_supportedNodeTypes;

						supportedEngineVersion_supportedEngines.Add(supportedEngine);
					}
					supportedEngineVersion.SupportedEngines = supportedEngineVersion_supportedEngines;

					availableZone_supportedEngineVersions.Add(supportedEngineVersion);
				}
				availableZone.SupportedEngineVersions = availableZone_supportedEngineVersions;

				describeAvailableResourceResponse_availableZones.Add(availableZone);
			}
			describeAvailableResourceResponse.AvailableZones = describeAvailableResourceResponse_availableZones;
        
			return describeAvailableResourceResponse;
        }
    }
}
