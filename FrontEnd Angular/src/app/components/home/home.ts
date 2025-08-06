import { Component, inject, OnInit } from '@angular/core';
import { FuncionarioService } from '../../services/funcionario-service';
import { FuncionarioModel } from '../../../models/FuncionarioModel';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { ExcluirFuncModal } from '../excluir-func-modal/excluir-func-modal';
import { materialImports } from '../../material';


@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule,RouterModule,materialImports],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit{


  funcionario : FuncionarioModel[] = [];
  colunas = ['Nome','Setor','Turno','Ações','Excluir']

//injeção de dependencia das versões atuais , assim os metodos que tiverem no service podem ser acessado igual ao construtor .
private funcionarioService = inject(FuncionarioService)
private dialog = inject(MatDialog)

ngOnInit(): void {

  this.funcionarioService.GetFuncionarios().subscribe((data)=>{
    this.funcionario = data.dados;
  })
}
OpenDialog(id:number){
  console.log('id pasado para o modal ',id)
  this.dialog.open(ExcluirFuncModal,{
    width:'450px',
    height:'450px',
    data:{
      id:id
    }
  });

}
}



