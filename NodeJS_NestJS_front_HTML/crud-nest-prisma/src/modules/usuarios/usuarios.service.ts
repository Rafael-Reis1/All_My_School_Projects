import { Injectable } from '@nestjs/common';
import { PrismaService } from 'src/database/PrismaService';
import { UsuarioDTO } from './usuario.dto';

@Injectable()
export class UsuariosService {
    constructor(private prisma: PrismaService){}
    async create(data: UsuarioDTO) {
        const userExists = await this.prisma.usuario.findFirst({
            where: {
                cpf: data.cpf
            }
        });
        if (userExists) {
            throw new Error("User already exists")
        }
        const user = await this.prisma.usuario.create({
            data
        });
        return user;
    }
    
    async findAll() {
        return this.prisma.usuario.findMany();
    }

    async update(id: string, data: UsuarioDTO) {
        const userExists = await this.prisma.usuario.findUnique({
            where: {
                id
            }
        });

        if (!userExists) {
            throw new Error('User does not exists!');
        }

        return await this.prisma.usuario.update({
            data,
            where: {
                id
            }
        });
    }

    async deleteMany(data: { id: string}[]) {
        const ids = data.map(usuario => usuario.id);
        const userExists = await this.prisma.usuario.findMany({
            where: {
                id: { in: ids }
            }
        });

        if(userExists.length === 0) {
            throw new Error('User does not exists!');
        }
        return await this.prisma.usuario.deleteMany({
            where: {
                id: { in: ids }
            }
        });
    }
}
