import Entity from './entity';

export default class category extends Entity<string> {
    name!: string;
    count!: number;
}