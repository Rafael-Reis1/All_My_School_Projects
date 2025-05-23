import { Module } from '@nestjs/common';
import { ImoveisModule } from './modules/imoveis/imoveis.module';
import { ReservasModule } from './modules/reservas/reservas.module';
import { UsuariosModule } from './modules/usuarios/usuarios.module';
import { AuthModule } from './modules/auth/auth.module';
import { APP_GUARD } from '@nestjs/core';
import { JwtAuthGuard } from './modules/auth/guards/jwt-auth.guard';
import { SystemModule } from './modules/system/system.module';

@Module({
  imports: [ImoveisModule, ReservasModule, UsuariosModule, AuthModule, SystemModule],
  controllers: [],
  providers: [
    {
      provide: APP_GUARD,
      useClass: JwtAuthGuard
    }
  ]
})
export class AppModule {}