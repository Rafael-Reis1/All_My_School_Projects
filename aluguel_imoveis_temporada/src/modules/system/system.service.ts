import { Injectable } from '@nestjs/common';
import * as si from 'systeminformation';

@Injectable()
export class SystemService {
  async cpuInfo() {
    return await si.cpu();
  }

  async currentLoad() {
    return await si.currentLoad();
  }

  async memInfo() {
    return await si.mem();
  }

  async diskLayoutInfo() {
    return await si.diskLayout();
  }

  async fsSizeInfo() {
    return await si.fsSize();
  }

  async fsStatsInfo() {
    return await si.fsStats();
  }

  async networkInterfacesInfo() {
    return await si.networkInterfaces();
  }

  async networkStatsInfo() {
    return await si.networkStats();
  }

  async networkConnectionsInfo() {
    return await si.networkConnections();
  }

  async processesInfo() {
    return await si.processes();
  }

  async batteryInfo() {
    return await si.battery();
  }

  async cpuTemperatureInfo() {
    return await si.cpuTemperature();
  }

  async graphicsInfo() {
    return await si.graphics();
  }

  async osInfo() {
    return await si.osInfo();
  }

  async systemInfo() {
    return await si.system();
  }

  async baseboardInfo() {
    return await si.baseboard();
  }

  async biosInfo() {
    return await si.bios();
  }

  async audioInfo() {
    return await si.audio();
  }

  async usbInfo() {
    return await si.usb();
  }
}
