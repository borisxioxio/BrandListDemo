import { Component, OnDestroy, OnInit } from "@angular/core";
import { Subscription } from "rxjs";
import { Brand } from "../shared/brand";
import { BrandDataService } from "../shared/brand-data.service";

@Component({
  selector: "app-brand-list",
  templateUrl: "./brand-list.component.html",
  styleUrls: ["./brand-list.component.css"],
})
export class BrandListComponent implements OnInit {
  allBrands: Brand[] = [];
  paginateBrands: Brand[] = [];

  page = 1;
  pageSize = 4;
  collectionSize = 0;

  constructor(private brandList: BrandDataService) {}

  ngOnInit() {
    this.brandList.loadBrands().subscribe((data) => {
      this.allBrands = data;
      this.collectionSize = this.allBrands.length;
      this.getPaginateBrands();
    });
  }

  getPaginateBrands() {
    this.paginateBrands = this.allBrands.slice(
      (this.page - 1) * this.pageSize,
      (this.page - 1) * this.pageSize + this.pageSize
    );
  }
}
