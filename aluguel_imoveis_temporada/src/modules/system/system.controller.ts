import { Controller, Get, Post, Body, Patch, Param, Delete } from '@nestjs/common';
import { SystemService } from './system.service';

@Controller('system')
export class SystemController {
  constructor(private readonly systemService: SystemService, private readonly SystemService: SystemService) {}

  @Get('cpu')
  async getCpuInfo() {
    return await this.systemService.cpuInfo();
  }

  @Get('load')
  async getCurrentLoad() {
    return await this.systemService.currentLoad();
  }

  @Get('memory')
  async getMemoryInfo() {
    return await this.systemService.memInfo();
  }

  @Get('disk-layout')
  async getDiskLayoutInfo() {
    return await this.systemService.diskLayoutInfo();
  }

  @Get('fs-size')
  async getFsSizeInfo() {
    return await this.systemService.fsSizeInfo();
  }

  @Get('fs-stats')
  async getFsStatsInfo() {
    return await this.systemService.fsStatsInfo();
  }

  @Get('network-interfaces')
  async getNetworkInterfacesInfo() {
    return await this.systemService.networkInterfacesInfo();
  }

  @Get('network-stats')
  async getNetworkStatsInfo() {
    return await this.systemService.networkStatsInfo();
  }

  @Get('network-connections')
  async getNetworkConnectionsInfo() {
    return await this.systemService.networkConnectionsInfo();
  }

  @Get('processes')
  async getProcessesInfo() {
    return await this.systemService.processesInfo();
  }

  @Get('battery')
  async getBatteryInfo() {
    return await this.systemService.batteryInfo();
  }

  @Get('cpu-temperature')
  async getCpuTemperatureInfo() {
    return await this.systemService.cpuTemperatureInfo();
  }

  @Get('graphics')
  async getGraphicsInfo() {
    return await this.systemService.graphicsInfo();
  }

  @Get('os')
  async getOsInfo() {
    return await this.systemService.osInfo();
  }

  @Get('system')
  async getSystemInfo() {
    return await this.systemService.systemInfo();
  }

  @Get('baseboard')
  async getBaseboardInfo() {
    return await this.systemService.baseboardInfo();
  }

  @Get('bios')
  async getBiosInfo() {
    return await this.systemService.biosInfo();
  }

  @Get('audio')
  async getAudioInfo() {
    return await this.systemService.audioInfo();
  }

  @Get('usb')
  async getUsbInfo() {
    return await this.systemService.usbInfo();
  }
}
