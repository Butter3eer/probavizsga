import { IsEnum, IsNotEmpty, IsOptional, IsString } from 'class-validator';
import { members_gender } from '@prisma/client';

export class CreateMemberDto {
  @IsString()
  @IsNotEmpty()
  name : string;

  @IsOptional()
  @IsEnum(members_gender)
  gender?: members_gender;
}
