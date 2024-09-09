import { Body, Controller, Post, Get, Put, Param, Delete } from '@nestjs/common';
import { UsuariosService } from './usuarios.service';
import { UsuarioDTO } from './usuario.dto';

@Controller('usuarios')
export class UsuariosController {
  constructor(private readonly usuariosService: UsuariosService) {}

  @Post()
  async create(@Body() data: UsuarioDTO){
    return this.usuariosService.create(data);
  }

  @Get()
  async findAll() {
    return this.usuariosService.findAll();
  }

  @Put(':id')
  async update(@Param('id') id: string, @Body() data: UsuarioDTO) {
    return this.usuariosService.update(id, data);
  }

  @Delete('many')
  async deleteMany(@Body() data: { id: string}[]) {
    return this.usuariosService.deleteMany(data);
  }
}