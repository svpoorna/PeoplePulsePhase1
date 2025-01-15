import type { NextConfig } from "next";

const nextConfig: NextConfig = {
  /* config options here */
  async redirects() {
    return [
      {
        source: '/',
        destination: '/admin',
        permanent: true, // This makes the redirect permanent (301)
      },
    ];
  },
};

export default nextConfig;
