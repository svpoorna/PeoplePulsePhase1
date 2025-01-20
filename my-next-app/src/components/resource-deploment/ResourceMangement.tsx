import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs";
import ResourceAllocation from "./ResourceAllocation";
import ResourceDeallocation from "./ResourceDeallocation";
import ProjectOverview from "./ProjectOverview";

export default function ResourceManagement() {
  return (
    <Tabs defaultValue="allocate" className="w-full">
      <TabsList className="grid w-full grid-cols-3">
        <TabsTrigger value="allocate">Allocate Resources</TabsTrigger>
        <TabsTrigger value="deallocate">Deallocate Resources</TabsTrigger>
        <TabsTrigger value="overview">Project Overview</TabsTrigger>
      </TabsList>
      <TabsContent value="allocate">
        <ResourceAllocation />
      </TabsContent>
      <TabsContent value="deallocate">
        <ResourceDeallocation />
      </TabsContent>
      <TabsContent value="overview">
        <ProjectOverview />
      </TabsContent>
    </Tabs>
  );
}