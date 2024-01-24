import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Ecom',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44323/',
    redirectUri: baseUrl,
    clientId: 'Ecom_App',
    responseType: 'code',
    scope: 'offline_access Ecom',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44323',
      rootNamespace: 'Polygon.Ecom',
    },
  },
} as Environment;
