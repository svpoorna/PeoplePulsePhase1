"use client";
import {
  User,
  LayoutDashboard,
  Settings,
  LogOut,
  Clock5,
  FolderOpenDot,
  Container,
  Notebook,
  GlobeLock,
  CalendarFold,
  CalendarDays,
} from "lucide-react";
import {
  Tooltip,
  TooltipContent,
  TooltipProvider,
  TooltipTrigger,
} from "@/components/ui/tooltip";
import {
  Sidebar,
  SidebarContent,
  SidebarGroup,
  SidebarGroupLabel,
  SidebarHeader,
  SidebarTrigger,
} from "@/components/ui/sidebar";
import { Button } from "../ui/button";
import { useSidebar } from "@/components/ui/sidebar";
import { useRouter } from "next/navigation";
import { useState } from "react";
import AdminSidebarListItem from "./admin-sidebar-listitem";
import { usePathname  } from "next/navigation";

export function AdminSidebar() {
  const params = usePathname()
  const router = useRouter();
  const [activeItem, setActiveItem] = useState<string>(params);
  const { open, state } = useSidebar();
  console.log(state, open);

  const handleLogout = async () => {
    console.log("logged out")
  };

  const sidebarItems = [
    { href: '/admin', icon: LayoutDashboard, label: 'Dashboard' },
    { href: '/admin/manage-project', icon: FolderOpenDot, label: 'Manage Project' },
    { href: '/admin/manage-resource', icon: User, label: 'Manage Resource' },
    { href: '/admin/manage-supplier', icon: Container, label: 'Manage Supplier' },
    { href: '/admin/timesheet', icon: Clock5, label: 'TImesheets' },
    { href: '/admin/resource-deployment', icon: GlobeLock, label: 'Resource Deployment' },
    { href: '/admin/roster-management', icon: CalendarFold, label: 'Roster Management' },
    { href: '/admin/apply-leaves', icon: CalendarDays, label: 'Apply Leaves' },
    { href: '/admin/report', icon: Notebook, label: 'Reports' },
  ];


  return (
    <Sidebar collapsible="icon" className="shadow-right">
      {state === "expanded" ? (
        <>
          <SidebarHeader className="flex gap-y-4 pt-5 w-full">
            <div className="flex w-full items-center">
              <SidebarTrigger />
              <div className="flex w-full justify-between items-center">
                <SidebarGroupLabel className="text-2xl text-primary-one font-medium">
                  Menu
                </SidebarGroupLabel>
                <SidebarGroupLabel className="gap-2">
                  <TooltipProvider>
                    <Tooltip>
                      <TooltipTrigger asChild>
                        <Button
                          variant="ghost"
                          size="icon"
                          className="border border-black rounded-sm h-7 w-7"
                          onClick={handleLogout}
                        >
                          <LogOut className="border-black" />
                        </Button>
                      </TooltipTrigger>
                      <TooltipContent>
                        <p>Logout</p>
                      </TooltipContent>
                    </Tooltip>
                  </TooltipProvider>
                </SidebarGroupLabel>
              </div>
            </div>
          </SidebarHeader>
          <SidebarGroup className="pt-8">
            <SidebarContent className="flex flex-row justify-start items-center w-full">
              <div className="w-full">
                <ul className="w-full px-4">
                {sidebarItems.map((item) => (
            <AdminSidebarListItem
              key={item.href}
              href={item.href}
              icon={item.icon}
              label={item.label}
              isActive={activeItem === item.href}
              onClick={() => setActiveItem(item.href)}
            />
          ))}
                </ul>
              </div>
            </SidebarContent>
          </SidebarGroup>
        </>
      ) : (
        <div className="flex flex-col w-full h-full py-2 justify-between items-center">
            <SidebarTrigger />
          <Button
            variant="ghost"
            size="icon"
            className="border border-black rounded-sm h-7 w-7"
            onClick={handleLogout}
          >
            <LogOut className="border-black" />
          </Button>
        </div>
      )}
    </Sidebar>
  );
}
